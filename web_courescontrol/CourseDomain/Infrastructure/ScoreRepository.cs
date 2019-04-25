using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseDomain.Entities
{
    public class ScoreRepository
    {
        public void Add(int id, int code)
        {
            using (var context = new coursecontrolContext())
            {
                Score score =new Score();
                score.CstuId = id;
                score.CcourseCode = code;
                context.Score.Add(score);
                context.SaveChanges();
            }
        }
        public void Delete(Score score)
        {
            using (var context = new coursecontrolContext())
            {
                context.Score.Remove(score);
                context.SaveChanges();
            }
        }
        public void Update(Score score)
        {
            using (var context = new coursecontrolContext())
            {
                context.Score.Update(score);
                context.SaveChanges();
            }
        }
        public List<Score> Query(int id)
        {
            List<Score> listScore = new List<Score>();
            using (var context = new coursecontrolContext())
            {
                listScore = (from u in context.Score
                             where u.CstuId == id
                             select u
                             ).ToList();
                context.SaveChanges();
            }
            return listScore;
        }
        public Score QueryByCode(int code,int id)
        {
            Score score = null;
            using (var context = new coursecontrolContext())
            {
                score = context.Score.FirstOrDefault(x => x.CcourseCode == code && x.CstuId == id);
                context.SaveChanges();
            }
            return score;
        }
    }
}
