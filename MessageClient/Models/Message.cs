using System; 
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MessageBoard.Models
{
  public class Message
  {
    public int MessageId { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    [DataType(DataType.Date)]
    public DateTime Date { get; set; }
    public string Author { get; set; }
    public int GroupId { get; set; }
		// public Group Group { get; set; }
	

    public static List<Message> GetMessages()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Message> messageList = JsonConvert.DeserializeObject<List<Message>>(jsonResponse.ToString());

      return messageList;
    }

    public static Message GetDetails(int id)
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert/DeserializeObject<JObject>(result);
      Message message = JsonConvert.DeserializeObject<Message>(jsonResponse.ToString());

      return message;
    }

    public static void Post(Message message)
    {
      string jsonMessage = JsonConvert.SerializeObject(message);
      var apiCallTask = ApiHelper.Post(jsonMessage);
    }

    public static void Put(Message message)
    {
      string jsonMessage = JsonConvert.SerializeObject(message);
      var apiCallTask = ApiHelper.Put(message.MessageId, jsonMessage);
    }

    public static void Delete(int id)
    {
      var apiCallTask = ApiHelper.Delete(id);
    }
  }
}