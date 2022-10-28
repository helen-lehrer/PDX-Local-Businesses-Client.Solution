using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PdxLocalBusinessesClient.Models
{
  public class Neighborhood
  {
		public Neighborhood()
		{
			this.Businesses = new HashSet<Business>();
		}
    public int NeighborhoodId { get; set; }
    public string Name { get; set; }
		public ICollection<Business> Businesses {get; set;}

    // public static List<Neighborhood> GetNeighborhoods()
    // {
    //   var apiCallTask = ApiHelper.NeighborhoodGetAll();
    //   var result = apiCallTask.Result;

    //   JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
    //   List<Neighborhood> neighborhoodList = JsonConvert.DeserializeObject<List<Neighborhood>>(jsonResponse.ToString());

    //   return neighborhoodList;
    // }

    // public static Neighborhood GetDetails(int id)
    // {
    //   var apiCallTask = ApiHelper.NeighborhoodGet(id);
    //   var result = apiCallTask.Result;

    //   JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
    //   Neighborhood neighborhood = JsonConvert.DeserializeObject<Neighborhood>(jsonResponse.ToString());

    //   return neighborhood;
    // }

    // public static void Post(Neighborhood neighborhood)
    // {
    //   string jsonNeighborhood = JsonConvert.SerializeObject(neighborhood);
    //   var apiCallTask = ApiHelper.NeighborhoodPost(jsonNeighborhood);
    // }

    // public static void Put(Neighborhood neighborhood)
    // {
    //   string jsonNeighborhood = JsonConvert.SerializeObject(neighborhood);
    //   var apiCallTask = ApiHelper.NeighborhoodPut(neighborhood.NeighborhoodId, jsonNeighborhood);
    // }

    // public static void Delete(int id)
    // {
    //   var apiCallTask = ApiHelper.NeighborhoodDelete(id);
    // }
  }
}