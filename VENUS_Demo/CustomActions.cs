/*
 * Created by Ranorex
 * User: jbranham
 * Date: 6/4/2020
 * Time: 2:25 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

using Lego;

namespace VENUS_Demo
{
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class CustomActions
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void CustomAction1(Adapter repoItem, string whatToType)
        {
        	repoItem.Click();
        	repoItem.PressKeys(whatToType);
        }
    }
}
