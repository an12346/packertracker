using System; // directive - tells it what code it needs in order to function.
using System.Collections.Generic; // if using list objects

//Pack item
//*Description
//*Purchased or not
//*Packed or not
//*Needs to be checked or not

//Stuff for MVC
//*id
//*static list of pack items
//*getall
//*clearall
//*find
//*remove by id Item.Find(3).Removed = true;

namespace PackerTracker.Models
{
  public class Item
  {
    public string Description { get; set; }
    public bool Purchased { get; set; }
    public bool Packed { get; set; }
    public bool Checked { get; set; }
    public int Id { get; }
    public bool Removed { get; set; }

    private static List<Item> _instances = new List<Item> {};

    public Item(string description) 
    { 
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;

      Purchased = false;
      Packed = false;
      Checked = false;
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Item Find(int id)
    {
      return _instances[id - 1];
    }
  }
}