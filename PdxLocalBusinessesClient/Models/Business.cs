using System; 
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace PdxLocalBusinessesClient.Models
{
  public class Business
  {
    public int BusinessId { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public string PhoneNumber { get; set; }
    public int NeighborhoodId { get; set; }
		public Neighborhood Neighborhood { get; set; }
	
    public static List<Business> GetBusinesses()
    {
      var apiCallTask = ApiHelper.GetAllBusinesses();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Business> businessList = JsonConvert.DeserializeObject<List<Business>>(jsonResponse.ToString());

      return businessList;
    }
  }
}