//Index GET "/items"
//New GET "/items/new"
//Create POST "/items"
//Show GET "/items/{id}"

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PackerTracker.Models;

namespace PackerTracker.Controllers
{
  public class ItemsController : Controller
  {

    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }

    [HttpGet("/items/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(string description)
    {
      Item myItem = new Item(description);
      return RedirectToAction("Index");
    }

    [HttpGet("/items/{id}")]
    public ActionResult Show(int id)
    {
      Item foundItem = Item.Find(id);
      return View(foundItem);
    }

    [HttpGet("/items/{id}/edit")]
    public ActionResult Edit(int id)
    {
      Item editItem = Item.Find(id);
      return View(editItem);
    }

    [HttpPost("/items/{id}")]
    public ActionResult Update(int id, bool purchased = false, bool packed = false, bool bagchecked = false)
    {
      Item updateItem = Item.Find(id);
      if (purchased)
      {
        updateItem.Purchased = true;
      }
      else 
      {
        updateItem.Purchased = false;
      }
      if (packed)
      {
        updateItem.Packed = true;
      }
      else 
      {
        updateItem.Packed = false;
      }
      if (bagchecked)
      {
        updateItem.BagChecked = true;
      }
      else 
      {
        updateItem.BagChecked = false;
      }
      return RedirectToAction("Show", new { id = id } );
    }
  }
}