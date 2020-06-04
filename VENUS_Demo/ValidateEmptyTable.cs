﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

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
using Ranorex.Core.Repository;

namespace VENUS_Demo
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ValidateEmptyTable recording.
    /// </summary>
    [TestModule("ad4b699b-661a-4891-892c-6e910118751c", ModuleType.Recording, 1)]
    public partial class ValidateEmptyTable : ITestModule
    {
        /// <summary>
        /// Holds an instance of the VENUS_DemoRepository repository.
        /// </summary>
        public static VENUS_DemoRepository repo = VENUS_DemoRepository.Instance;

        static ValidateEmptyTable instance = new ValidateEmptyTable();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateEmptyTable()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateEmptyTable Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='VIP count: 0') on item 'ApplicationUnderTest.Count'.", repo.ApplicationUnderTest.CountInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.ApplicationUnderTest.CountInfo, "InnerText", "VIP count: 0");
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(1));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
