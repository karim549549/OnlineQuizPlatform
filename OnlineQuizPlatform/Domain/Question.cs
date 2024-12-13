using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuizPlatform.Domain
{
    public class Question
    {
        public int  Id { get; set; }
        public string  Text  { get; set; }
        public  List<string> Options { get; set; }
        public  int  CorrectAnswerIndex {  get; set; }
        public  int Score  { get; set; }
    }
}
