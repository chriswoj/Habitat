﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sitecore.Feature.Accounts.Specflow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class SaveUserDetailsInXDBFeature : Xunit.IClassFixture<SaveUserDetailsInXDBFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Save user details in xDB.feature"
#line hidden
        
        public SaveUserDetailsInXDBFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Save user details in xDB", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void SetFixture(SaveUserDetailsInXDBFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Save user details in xDB")]
        [Xunit.TraitAttribute("Description", "Account_Save user details in xDB_UC1_Save full info")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void Account_SaveUserDetailsInXDB_UC1_SaveFullInfo()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Save user details in xDB_UC1_Save full info", new string[] {
                        "NeedImplementation"});
#line 5
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table1.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 6
 testRunner.Given("User with following data is registered in Habitat", ((string)(null)), table1, "Given ");
#line 9
 testRunner.And("Habitat website is opened on Edit Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Last Name",
                        "First Name",
                        "Phone number"});
            table2.AddRow(new string[] {
                        "Maximov",
                        "Stas",
                        "+38(067)3333333"});
#line 10
 testRunner.And("User inputs data in to the fields", ((string)(null)), table2, "And ");
#line 13
 testRunner.And("User selects <Skiing> from Interests drop-down list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.When("User clicks Save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.And("User opens MongoDB", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "Surname"});
            table3.AddRow(new string[] {
                        "Stas",
                        "Maximov"});
#line 16
 testRunner.Then("Contact collection Personal section consist of", ((string)(null)), table3, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number"});
            table4.AddRow(new string[] {
                        "+38(067)3333333"});
#line 19
 testRunner.And("Contact collection Phone Numbers section consist of", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "SmtpAddress"});
            table5.AddRow(new string[] {
                        "kov@sitecore.net"});
#line 22
 testRunner.And("Contact collection Emails section consist of", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "\"0\""});
            table6.AddRow(new string[] {
                        "Skiing"});
#line 25
 testRunner.And("Contact collection Tags.Interests.Values section consist of", ((string)(null)), table6, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Save user details in xDB")]
        [Xunit.TraitAttribute("Description", "Account_Save user details in xDB_UC2_Update full user info")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void Account_SaveUserDetailsInXDB_UC2_UpdateFullUserInfo()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Save user details in xDB_UC2_Update full user info", new string[] {
                        "NeedImplementation"});
#line 36
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Last Name",
                        "First Name",
                        "Phone number",
                        "Interests"});
            table7.AddRow(new string[] {
                        "Teltov",
                        "Konstantin",
                        "+38(067)3333333",
                        "Swiming"});
#line 37
 testRunner.Given("Habitat user was created and updated with following info", ((string)(null)), table7, "Given ");
#line 40
 testRunner.And("Habitat website is opened on Edit Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Last Name",
                        "First Name",
                        "Phone number"});
            table8.AddRow(new string[] {
                        "Maximov",
                        "Stas",
                        "+38(067)8888888"});
#line 41
 testRunner.When("User inputs data in to the fields", ((string)(null)), table8, "When ");
#line 44
 testRunner.And("User selects <Skiing> from Interests drop-down list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.And("User clicks Save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.And("User opens MongoDB", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "Surname"});
            table9.AddRow(new string[] {
                        "Stas",
                        "Maximov"});
#line 47
 testRunner.Then("Contact collection Personal section consist of", ((string)(null)), table9, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number"});
            table10.AddRow(new string[] {
                        "+38(067)8888888"});
#line 50
 testRunner.And("Contact collection Phone Numbers section consist of", ((string)(null)), table10, "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "SmtpAddress"});
            table11.AddRow(new string[] {
                        "kov@sitecore.net"});
#line 53
 testRunner.And("Contact collection Emails section consist of", ((string)(null)), table11, "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "\"0\"",
                        "\"1\""});
            table12.AddRow(new string[] {
                        "Swiming",
                        "Skiing"});
#line 56
 testRunner.And("Contact collection Tags.Interests.Values section consist of", ((string)(null)), table12, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Save user details in xDB")]
        [Xunit.TraitAttribute("Description", "Account_Save user details in xDB_UC3_Save only one of the name fields")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void Account_SaveUserDetailsInXDB_UC3_SaveOnlyOneOfTheNameFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Save user details in xDB_UC3_Save only one of the name fields", new string[] {
                        "NeedImplementation"});
#line 65
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table13.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 66
 testRunner.Given("User with following data is registered in Habitat", ((string)(null)), table13, "Given ");
#line 69
 testRunner.And("Habitat website is opened on Edit Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Last Name"});
            table14.AddRow(new string[] {
                        "Maximov"});
#line 70
 testRunner.When("User inputs data in to the fields", ((string)(null)), table14, "When ");
#line 73
 testRunner.And("User clicks Save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.And("User opens MongoDB", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Surname"});
            table15.AddRow(new string[] {
                        "Maximov"});
#line 75
 testRunner.Then("Contact collection Personal section consist of", ((string)(null)), table15, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "SmtpAddress"});
            table16.AddRow(new string[] {
                        "kov@sitecore.net"});
#line 78
 testRunner.And("Contact collection Emails section consist of", ((string)(null)), table16, "And ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field"});
            table17.AddRow(new string[] {
                        "Surname"});
#line 81
 testRunner.And("Contact collection Personal section has no fields", ((string)(null)), table17, "And ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field"});
            table18.AddRow(new string[] {
                        "Number"});
#line 84
 testRunner.And("Contact collection Phone Numbers section has no fields", ((string)(null)), table18, "And ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field"});
            table19.AddRow(new string[] {
                        "Value"});
#line 87
 testRunner.And("Contact collection Tags.Interests.Values section has no fields", ((string)(null)), table19, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Save user details in xDB")]
        [Xunit.TraitAttribute("Description", "Account_Save user details in xDB_UC4_Save only phone number")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void Account_SaveUserDetailsInXDB_UC4_SaveOnlyPhoneNumber()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Save user details in xDB_UC4_Save only phone number", new string[] {
                        "NeedImplementation"});
#line 93
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table20.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 94
 testRunner.Given("User with following data is registered in Habitat", ((string)(null)), table20, "Given ");
#line 97
 testRunner.And("Habitat website is opened on Edit Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Phone number"});
            table21.AddRow(new string[] {
                        "+38(067)8888888"});
#line 98
 testRunner.When("User inputs data in to the fields", ((string)(null)), table21, "When ");
#line 101
 testRunner.And("User clicks Save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
 testRunner.And("User opens MongoDB", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number"});
            table22.AddRow(new string[] {
                        "+38(067)8888888"});
#line 103
 testRunner.Then("Contact collection Phone Numbers section consist of", ((string)(null)), table22, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "SmtpAddress"});
            table23.AddRow(new string[] {
                        "kov@sitecore.net"});
#line 106
 testRunner.And("Contact collection Emails section consist of", ((string)(null)), table23, "And ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field"});
            table24.AddRow(new string[] {
                        "Surname"});
            table24.AddRow(new string[] {
                        "Firstname"});
#line 109
 testRunner.And("Contact collection Personal section has no fields", ((string)(null)), table24, "And ");
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field"});
            table25.AddRow(new string[] {
                        "Value"});
#line 113
 testRunner.And("Contact collection Tags.Interests.Values section has no fields", ((string)(null)), table25, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Save user details in xDB")]
        [Xunit.TraitAttribute("Description", "Account_Save user details in xDB_UC5_Save only Interests")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void Account_SaveUserDetailsInXDB_UC5_SaveOnlyInterests()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Save user details in xDB_UC5_Save only Interests", new string[] {
                        "NeedImplementation"});
#line 120
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table26.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 121
 testRunner.Given("User with following data is registered in Habitat", ((string)(null)), table26, "Given ");
#line 124
 testRunner.And("Habitat website is opened on Edit Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
 testRunner.When("User selects <Skiing> from Interests drop-down list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 126
 testRunner.And("User clicks Save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 127
 testRunner.And("User opens MongoDB", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                        "\"0\""});
            table27.AddRow(new string[] {
                        "Skiing"});
#line 128
 testRunner.Then("Contact collection Tags.Interests.Values section consist of", ((string)(null)), table27, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                        "SmtpAddress"});
            table28.AddRow(new string[] {
                        "kov@sitecore.net"});
#line 131
 testRunner.And("Contact collection Emails section consist of", ((string)(null)), table28, "And ");
#line hidden
            TechTalk.SpecFlow.Table table29 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field"});
            table29.AddRow(new string[] {
                        "Surname"});
            table29.AddRow(new string[] {
                        "Firstname"});
#line 134
 testRunner.And("Contact collection Personal section has no fields", ((string)(null)), table29, "And ");
#line hidden
            TechTalk.SpecFlow.Table table30 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field"});
            table30.AddRow(new string[] {
                        "Number"});
#line 138
 testRunner.And("Contact collection Phone Numbers section has no fields", ((string)(null)), table30, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Save user details in xDB")]
        [Xunit.TraitAttribute("Description", "Account_Save user details in xDB_UC6_Update only one of the name fields")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void Account_SaveUserDetailsInXDB_UC6_UpdateOnlyOneOfTheNameFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Save user details in xDB_UC6_Update only one of the name fields", new string[] {
                        "NeedImplementation"});
#line 144
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table31 = new TechTalk.SpecFlow.Table(new string[] {
                        "Last Name",
                        "First Name",
                        "Phone number",
                        "Interests"});
            table31.AddRow(new string[] {
                        "Teltov",
                        "Konstantin",
                        "+38(067)3333333",
                        "Swiming"});
#line 145
 testRunner.Given("Habitat user was created and updated with following info", ((string)(null)), table31, "Given ");
#line 148
 testRunner.And("Habitat website is opened on Edit Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table32 = new TechTalk.SpecFlow.Table(new string[] {
                        "Last Name"});
            table32.AddRow(new string[] {
                        "Maximov"});
#line 149
 testRunner.When("User inputs data in to the fields", ((string)(null)), table32, "When ");
#line 152
 testRunner.And("User clicks Save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 153
 testRunner.And("User opens MongoDB", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table33 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "Surname"});
            table33.AddRow(new string[] {
                        "Konstantin",
                        "Maximov"});
#line 154
 testRunner.Then("Contact collection Personal section consist of", ((string)(null)), table33, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table34 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number"});
            table34.AddRow(new string[] {
                        "+38(067)3333333"});
#line 157
 testRunner.And("Contact collection Phone Numbers section consist of", ((string)(null)), table34, "And ");
#line hidden
            TechTalk.SpecFlow.Table table35 = new TechTalk.SpecFlow.Table(new string[] {
                        "SmtpAddress"});
            table35.AddRow(new string[] {
                        "kov@sitecore.net"});
#line 160
 testRunner.And("Contact collection Emails section consist of", ((string)(null)), table35, "And ");
#line hidden
            TechTalk.SpecFlow.Table table36 = new TechTalk.SpecFlow.Table(new string[] {
                        "\"0\""});
            table36.AddRow(new string[] {
                        "Swiming"});
#line 163
 testRunner.And("Contact collection Tags.Interests.Values section consist of", ((string)(null)), table36, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Save user details in xDB")]
        [Xunit.TraitAttribute("Description", "Account_Save user details in xDB_UC7_Update only phone number")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void Account_SaveUserDetailsInXDB_UC7_UpdateOnlyPhoneNumber()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Save user details in xDB_UC7_Update only phone number", new string[] {
                        "NeedImplementation"});
#line 169
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table37 = new TechTalk.SpecFlow.Table(new string[] {
                        "Last Name",
                        "First Name",
                        "Phone number",
                        "Interests"});
            table37.AddRow(new string[] {
                        "Teltov",
                        "Konstantin",
                        "+38(067)3333333",
                        "Swiming"});
#line 170
 testRunner.Given("Habitat user was created and updated with following info", ((string)(null)), table37, "Given ");
#line 173
 testRunner.And("Habitat website is opened on Edit Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table38 = new TechTalk.SpecFlow.Table(new string[] {
                        "Phone number"});
            table38.AddRow(new string[] {
                        "+38(067)8888888"});
#line 174
 testRunner.When("User inputs data in to the fields", ((string)(null)), table38, "When ");
#line 177
 testRunner.And("User clicks Save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 178
 testRunner.And("User opens MongoDB", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table39 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "Surname"});
            table39.AddRow(new string[] {
                        "Konstantin",
                        "Teltov"});
#line 179
 testRunner.Then("Contact collection Personal section consist of", ((string)(null)), table39, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table40 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number"});
            table40.AddRow(new string[] {
                        "+38(067)8888888"});
#line 182
 testRunner.And("Contact collection Phone Numbers section consist of", ((string)(null)), table40, "And ");
#line hidden
            TechTalk.SpecFlow.Table table41 = new TechTalk.SpecFlow.Table(new string[] {
                        "SmtpAddress"});
            table41.AddRow(new string[] {
                        "kov@sitecore.net"});
#line 185
 testRunner.And("Contact collection Emails section consist of", ((string)(null)), table41, "And ");
#line hidden
            TechTalk.SpecFlow.Table table42 = new TechTalk.SpecFlow.Table(new string[] {
                        "\"0\""});
            table42.AddRow(new string[] {
                        "Swiming"});
#line 188
 testRunner.And("Contact collection Tags.Interests.Values section consist of", ((string)(null)), table42, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Save user details in xDB")]
        [Xunit.TraitAttribute("Description", "Account_Save user details in xDB_UC8_Update only only Interests")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void Account_SaveUserDetailsInXDB_UC8_UpdateOnlyOnlyInterests()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Save user details in xDB_UC8_Update only only Interests", new string[] {
                        "NeedImplementation"});
#line 193
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table43 = new TechTalk.SpecFlow.Table(new string[] {
                        "Last Name",
                        "First Name",
                        "Phone number",
                        "Interests"});
            table43.AddRow(new string[] {
                        "Teltov",
                        "Konstantin",
                        "+38(067)3333333",
                        "Swiming"});
#line 194
 testRunner.Given("Habitat user was created and updated with following info", ((string)(null)), table43, "Given ");
#line 197
 testRunner.And("Habitat website is opened on Edit Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 198
 testRunner.When("User selects <Skiing> from Interests drop-down list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 199
 testRunner.And("User clicks Save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 200
 testRunner.And("User opens MongoDB", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table44 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "Surname"});
            table44.AddRow(new string[] {
                        "Konstantin",
                        "Teltov"});
#line 201
 testRunner.Then("Contact collection Personal section consist of", ((string)(null)), table44, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table45 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number"});
            table45.AddRow(new string[] {
                        "+38(067)3333333"});
#line 204
 testRunner.And("Contact collection Phone Numbers section consist of", ((string)(null)), table45, "And ");
#line hidden
            TechTalk.SpecFlow.Table table46 = new TechTalk.SpecFlow.Table(new string[] {
                        "SmtpAddress"});
            table46.AddRow(new string[] {
                        "kov@sitecore.net"});
#line 207
 testRunner.And("Contact collection Emails section consist of", ((string)(null)), table46, "And ");
#line hidden
            TechTalk.SpecFlow.Table table47 = new TechTalk.SpecFlow.Table(new string[] {
                        "\"0\"",
                        "\"1\""});
            table47.AddRow(new string[] {
                        "Swiming",
                        "Skiing"});
#line 210
 testRunner.And("Contact collection Tags.Interests.Values section consist of", ((string)(null)), table47, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Save user details in xDB")]
        [Xunit.TraitAttribute("Description", "Account_Save user details in xDB_UC9_Update system section in xDB")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void Account_SaveUserDetailsInXDB_UC9_UpdateSystemSectionInXDB()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Save user details in xDB_UC9_Update system section in xDB", new string[] {
                        "NeedImplementation"});
#line 216
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table48 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table48.AddRow(new string[] {
                        "kov10@sitecore.net",
                        "k",
                        "k"});
#line 217
 testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table48, "Given ");
#line 220
 testRunner.And("Habitat website is opened on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table49 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table49.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 221
 testRunner.When("Actor enteres following data into Login page fields", ((string)(null)), table49, "When ");
#line 224
 testRunner.And("User clicks Login button on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 225
 testRunner.And("User clicks on <Info-sign> in the right down corner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 226
 testRunner.And("User clicks END VISIT button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 227
 testRunner.And("User opens MongoDB", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table50 = new TechTalk.SpecFlow.Table(new string[] {
                        "VisitCount",
                        "Value"});
            table50.AddRow(new string[] {
                        "2",
                        ""});
#line 228
 testRunner.Then("Contact collection System section consist of", ((string)(null)), table50, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Save user details in xDB")]
        [Xunit.TraitAttribute("Description", "Account_Save user details in xDB_UC10_Empty Interests value")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void Account_SaveUserDetailsInXDB_UC10_EmptyInterestsValue()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Save user details in xDB_UC10_Empty Interests value", new string[] {
                        "NeedImplementation"});
#line 234
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table51 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table51.AddRow(new string[] {
                        "kov10@sitecore.net",
                        "k",
                        "k"});
#line 235
 testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table51, "Given ");
#line 238
 testRunner.And("Habitat website is opened on Edit Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 239
 testRunner.When("User selects <Skiing> from Interests drop-down list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 240
 testRunner.And("User clicks Save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 241
 testRunner.And("User selects <Skiing> from Interests drop-down list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 242
 testRunner.And("User clicks Save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 243
 testRunner.And("User opens MongoDB", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table52 = new TechTalk.SpecFlow.Table(new string[] {
                        "\"0\"",
                        "\"1\""});
            table52.AddRow(new string[] {
                        "Swiming",
                        "\"\""});
#line 244
 testRunner.Then("Contact collection Tags.Interests.Values section consist of", ((string)(null)), table52, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                SaveUserDetailsInXDBFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                SaveUserDetailsInXDBFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
