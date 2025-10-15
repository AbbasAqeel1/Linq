using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
namespace Shared
{
    public class Question
    {
      

        public string Title { get; set; }
        public List<Choice> Choices { get; set; } = new();

        public int CorrectAnswer { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;

            var other = (Question)obj;

            return other.Title == this.Title && other.Choices.SequenceEqual(this.Choices)
                && other.CorrectAnswer == this.CorrectAnswer;
        }


        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + Title.GetHashCode();
            hash = hash * 23 + Choices.GetHashCode();
            hash = hash * 23 + CorrectAnswer.GetHashCode();

            return hash;
        }


        public override string ToString()
        {
            var choices = "";

            foreach (var item in Choices)
            {
                choices += $"\n\t{item.Order}) {item.Description}";
            }

            return $"{Title}" +
                   $"{choices}"; 
        }
    }
}
