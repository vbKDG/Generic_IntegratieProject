using System.IO.Pipes;

namespace Domain
{
    public class ReactionLike: Like
    {
       public Reaction reaction { get; set; }
    }
}