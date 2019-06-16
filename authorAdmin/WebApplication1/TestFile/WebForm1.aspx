<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.TestFile.WebForm1" %>
 
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
 
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>上传测试</title>
    <link rel="stylesheet" href="layui/css/layui.css" />
     <script type="text/javascript" src="jq/jquery.min.js"></script>
     <script type="text/javascript" src="layui/layui.js"></script>
 
</head>
<body>
 
    <div class="layui-form">
         <button id = "btn1" >按钮测试-显示上传</button>
         <button id = "btn2" >按钮测试-测试接口</button>
         <div class="layui-upload" id = "uploadXMJCFJDiv">
         </div>
    </div>
</body>
<script type="text/javascript">
    var upload;
    var uploadListIns;
    $(document).ready(function () {
        //上传
        $("#btn1").click(function () {
            alert("按钮btn1-初始化上传组件");
            createParentUpload(1);  //tzId请忽略，这是测试参数
        });
        //接口
        $("#btn2").click(function () {
            var jsonString = '{"DJName":"单据名称","DJID":"111","DJRemark":"这个是测试单据","DJContent":["FILE1","FILE2"]}';
            console.log("按钮btn2-测试接口-假数据jsonString = " + jsonString);
            var data = $.parseJSON(jsonString);
            urlform = "/NewTest/Handler1.ashx?fun=test1&danjuName=" + encodeURI(data.DJName) + "&danjuId=" + encodeURI(data.DJID) + "&djContent=" + encodeURI(data.DJContent);
            console.log("urlform = " + urlform);
            var a = $.ajax({
                type: "GET",
                url: urlform,
                //data:JSON.stringify(qjMap),
                dataType: "text",
                contentType: "application/html; charset=utf-8",
                success: function (res) {
                    console.log("res = " + res);
                }
            });
        });
    });
 
    layui.use(['form', 'element', 'upload'], function () {
        var $ = layui.jquery,
                element = layui.element,
                form = layui.form;
        upload = layui.upload;
        form.render("select");
    });
 
    function createParentUpload(tzId) {
        $("#uploadXMJCFJDiv").html("");
        var uploadInfo = '<button type="button" class="layui-btn layui-btn-normal" id="selectList">选择文件并上传</button>';
        uploadInfo += '<div class="layui-upload-list"><table class="layui-table">';
        uploadInfo += '<thead><tr><th>文件名</th><th>大小</th><th>状态</th><th>操作</th></tr></thead>';
        uploadInfo += '<tbody id="demoList"></tbody></table></div>';
        $("#uploadXMJCFJDiv").html(uploadInfo);
        initParentUpload(tzId);
    }
 
    function initParentUpload(tzId) {
        var demoListView = $('#demoList');
        var urlform = "/TestFile/Handler1.ashx";
        //执行实例
        uploadListIns = upload.render({
            elem: '#selectList' //绑定元素
            , url: urlform //上传接口
            , accept: 'file'
            , multiple: true
            , data: { tz_id: tzId }
            , choose: function (obj) {
                var files = this.files = obj.pushFile(); //将每次选择的文件追加到文件队列
                //读取本地文件
        obj.preview(function (index, file, result) {
            var tr = $(['<tr id="upload-' + index + '">'
          , '<td>' + file.name + '</td>'
          , '<td>' + (file.size / 1014).toFixed(1) + 'kb</td>'
          , '<td>等待上传</td>'
          , '<td>'
            , '<button class="layui-btn layui-btn-xs demo-reload layui-hide">重传</button>'
            , '<button class="layui-btn layui-btn-xs layui-btn-danger demo-delete">删除</button>'
          , '</td>'
        , '</tr>'].join(''));
 
            //单个重传
            tr.find('.demo-reload').on('click', function () {
                obj.upload(index, file);
            });
 
            //删除
            tr.find('.demo-delete').on('click', function () {
                delete files[index]; //删除对应的文件
                tr.remove();
                uploadListIns.config.elem.next()[0].value = ''; //清空 input file 值，以免删除后出现同名文件不可选
            });
 
            demoListView.append(tr);
        });
    }
    , done: function (res, index, upload) {
        //上传完毕回调
        layer.closeAll('loading'); //关闭loading
        console.log("res = " + res + ",res.code = " + res.code);
        if (res.code == 0) {
            var tr = demoListView.find('tr#upload-' + index)
          , tds = tr.children();
            tds.eq(2).html('<span style="color: #5FB878;">上传成功</span>');
            tds.eq(3).html(''); //清空操作
            //console.log("tzId = "+tzId+", data = "+res.data);
            return delete this.files[index]; //删除文件队列已经上传成功的文件
        }
        this.error(index, upload);
    }
    , error: function (index, upload) {
        //请求异常回调
        layer.closeAll('loading'); //关闭loading
        var tr = demoListView.find('tr#upload-' + index), tds = tr.children();
        tds.eq(2).html('<span style="color: #FF5722;">上传失败</span>');
        tds.eq(3).find('.demo-reload').removeClass('layui-hide'); //显示重传
    }
    , allDone: function (obj) { //当文件全部被提交后，才触发
        console.log(obj.total); //得到总文件数
        console.log(obj.successful); //请求成功的文件数
        console.log(obj.aborted); //请求失败的文件数
    }
    });
}
</script>
</html>