using System.Runtime.Serialization;

namespace WebApiCoreLecture.Helper
{
   public class MessageHelper
   {
      [DataMember]
      public string Message { get; set; }
      public int statuscode { get; set; }
      public long? autoId { get; set; }
   }
}
