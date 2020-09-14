/*
 * Author: Lukas Hurtig
 * Class: Menu.cs
 * Purpose: A static menu class that returns compiles all of the menu items
 */

using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.Data.Classification
{
    /// <summary>
    /// A static class that compiles all of the menu items and creates a
    /// list of them
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Creates a list of all entrees offered
        /// </summary>
        /// <returns>returns a collection of entrees offered</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();

            BriarheartBurger bb = new BriarheartBurger();
            entrees.Add(bb);

            DoubleDraugr dd = new DoubleDraugr();
            entrees.Add(dd);

            GardenOrcOmelette go = new GardenOrcOmelette();
            entrees.Add(go);

            PhillyPoacher pp = new PhillyPoacher();
            entrees.Add(pp);

            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            entrees.Add(ss);

            ThalmorTriple tt = new ThalmorTriple();
            entrees.Add(tt);

            ThugsTBone tBone = new ThugsTBone();
            entrees.Add(tBone);

            return entrees;
        }

        /// <summary>
        /// Creates a list of all sides offered
        /// </summary>
        /// <returns>returns a collection of sides offered</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                DragonbornWaffleFries dwf = new DragonbornWaffleFries();
                dwf.Size = size;
                sides.Add(dwf);

                FriedMiraak fm = new FriedMiraak();
                fm.Size = size;
                sides.Add(fm);

                MadOtarGrits mo = new MadOtarGrits();
                mo.Size = size;
                sides.Add(mo);

                VokunSalad vs = new VokunSalad();
                vs.Size = size;
                sides.Add(vs);
            }

            return sides;
        }

        /// <summary>
        /// Creates a list of all entrees offered
        /// </summary>
        /// <returns>returns a collection of drinks offered</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                ArentinoAppleJuice aj = new ArentinoAppleJuice();
                aj.Size = size;
                drinks.Add(aj);

                CandlehearthCoffee cc = new CandlehearthCoffee();
                cc.Size = size;
                drinks.Add(cc);

                MarkarthMilk mm = new MarkarthMilk();
                mm.Size = size;
                drinks.Add(mm);

                SailorSoda ss = new SailorSoda();
                ss.Size = size;
                drinks.Add(ss);

                WarriorWater ww = new WarriorWater();
                ww.Size = size;
                drinks.Add(ww);
            }

            return drinks;

        }

        /// <summary>
        /// Creates a list of all menu items offered implementing the prior
        /// three methods
        /// </summary>
        /// <returns>returns a collection of all menu items offered</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> fullMenu = new List<IOrderItem>();

            fullMenu.AddRange(Entrees());
            fullMenu.AddRange(Sides());
            fullMenu.AddRange(Drinks());

            return fullMenu;
        }
    }
}
