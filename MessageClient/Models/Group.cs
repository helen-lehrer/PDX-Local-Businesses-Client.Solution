using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MessageClient.Models
{
  public class Group
  {
		public Group()
		{
			this.Messages = new HashSet<Message>();
		}
    public int GroupId { get; set; }
    public string Name { get; set; }
		public ICollection<Message> Messages {get; set;}

    public static List<Group> GetGroups()
    {
      var apiCallTask = ApiHelper.GroupGetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Group> groupList = JsonConvert.DeserializeObject<List<Group>>(jsonResponse.ToString());

      return groupList;
    }

    public static Group GetDetails(int id)
    {
      var apiCallTask = ApiHelper.GroupGet(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Group group = JsonConvert.DeserializeObject<Group>(jsonResponse.ToString());

      return group;
    }

    public static void Post(Group group)
    {
      string jsonGroup = JsonConvert.SerializeObject(group);
      var apiCallTask = ApiHelper.GroupPost(jsonGroup);
    }

    public static void Put(Group group)
    {
      string jsonGroup = JsonConvert.SerializeObject(group);
      var apiCallTask = ApiHelper.GroupPut(group.GroupId, jsonGroup);
    }

    public static void Delete(int id)
    {
      var apiCallTask = ApiHelper.GroupDelete(id);
    }
  }
}