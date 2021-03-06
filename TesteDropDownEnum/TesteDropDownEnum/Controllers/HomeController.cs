﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TesteDropDownEnum.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Principal p = new Principal()
            {
                Item = MeuEnum.Item6
            };
            p.Teste = new List<Teste>();

            p.Teste.Add(new Teste() { item = MeuEnum.Item0 });
            p.Teste.Add(new Teste() { item = MeuEnum.Item1 });
            p.Teste.Add(new Teste() { item = MeuEnum.Item2 });
            p.Teste.Add(new Teste() { item = MeuEnum.Item3 });

            return View(p);
        }
    }

    public class Principal
    {
        public MeuEnum Item { get; set; }
        public List<Teste> Teste { get; set; }
    }

    public class Teste
    {
        public MeuEnum item { get; set; }
    }

    public enum MeuEnum
    {
        Item0 = 0,

        Item1 = 1,

        Item2 = 2,

        Item3 = 3,

        Item4 = 4,

        Item5 = 5,

        Item6 = 6,

        Item7 = 7,

        Item8 = 8,
    }

    public static class Helpers
    {
        public static IEnumerable<SelectListItem> MeuEnumItens3(this HtmlHelper html, MeuEnum? itemSelecionado)
        {
            var lista = new List<SelectListItem>();

            foreach (MeuEnum item in System.Enum.GetValues(typeof(MeuEnum)))
            {
                lista.Add(new SelectListItem() { Text = item.ToString("F"), Value = item.ToString(), Selected = (itemSelecionado.HasValue ? itemSelecionado.Value == item : false) });
            }

            return lista;
        }

        public static SelectList MeuEnumItens(this HtmlHelper html, MeuEnum? item = null)
        {
            var item0 = new SelectListItem() { Value = ((int)MeuEnum.Item0).ToString(), Selected = item != null ? item == MeuEnum.Item0 : false, Text = "0" };
            var item1 = new SelectListItem() { Value = ((int)MeuEnum.Item1).ToString(), Selected = item != null ? item == MeuEnum.Item1 : false, Text = "1" };
            var item2 = new SelectListItem() { Value = ((int)MeuEnum.Item2).ToString(), Selected = item != null ? item == MeuEnum.Item2 : false, Text = "2" };
            var item3 = new SelectListItem() { Value = ((int)MeuEnum.Item3).ToString(), Selected = item != null ? item == MeuEnum.Item3 : false, Text = "3" };
            var item4 = new SelectListItem() { Value = ((int)MeuEnum.Item4).ToString(), Selected = item != null ? item == MeuEnum.Item4 : false, Text = "4" };
            var item5 = new SelectListItem() { Value = ((int)MeuEnum.Item5).ToString(), Selected = item != null ? item == MeuEnum.Item5 : false, Text = "5" };
            var item6 = new SelectListItem() { Value = ((int)MeuEnum.Item6).ToString(), Selected = item != null ? item == MeuEnum.Item6 : false, Text = "6" };
            var item7 = new SelectListItem() { Value = ((int)MeuEnum.Item7).ToString(), Selected = item != null ? item == MeuEnum.Item7 : false, Text = "7" };
            var item8 = new SelectListItem() { Value = ((int)MeuEnum.Item8).ToString(), Selected = item != null ? item == MeuEnum.Item8 : false, Text = "8" };

            return new SelectList(new[] { item0, item1, item2, item3, item4, item5, item6, item7, item8 }, "Value", "Text");
        }

        public static IEnumerable<SelectListItem> MeuEnumItens2(this HtmlHelper html, MeuEnum? item = null)
        {
            var item0 = new SelectListItem() { Value = ((int)MeuEnum.Item0).ToString(), Selected = item == MeuEnum.Item0, Text = "0" };
            var item1 = new SelectListItem() { Value = ((int)MeuEnum.Item1).ToString(), Selected = item == MeuEnum.Item1, Text = "1" };
            var item2 = new SelectListItem() { Value = ((int)MeuEnum.Item2).ToString(), Selected = item == MeuEnum.Item2, Text = "2" };
            var item3 = new SelectListItem() { Value = ((int)MeuEnum.Item3).ToString(), Selected = item == MeuEnum.Item3, Text = "3" };
            var item4 = new SelectListItem() { Value = ((int)MeuEnum.Item4).ToString(), Selected = item == MeuEnum.Item4, Text = "4" };
            var item5 = new SelectListItem() { Value = ((int)MeuEnum.Item5).ToString(), Selected = item == MeuEnum.Item5, Text = "5" };
            var item6 = new SelectListItem() { Value = ((int)MeuEnum.Item6).ToString(), Selected = item == MeuEnum.Item6, Text = "6" };
            var item7 = new SelectListItem() { Value = ((int)MeuEnum.Item7).ToString(), Selected = item == MeuEnum.Item7, Text = "7" };
            var item8 = new SelectListItem() { Value = ((int)MeuEnum.Item8).ToString(), Selected = item == MeuEnum.Item8, Text = "8" };

            List<SelectListItem> items = new List<SelectListItem>();
            items.Add(item0);
            items.Add(item1);
            items.Add(item2);
            items.Add(item3);
            items.Add(item4);
            items.Add(item5);
            items.Add(item6);
            items.Add(item7);
            items.Add(item8);

            return items.AsEnumerable();
        }
    }
}