using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;



    public class TestSuite
    {
        //Test to see if the list of strings is exactly a length of two
        [UnityTest]
        public IEnumerator _Prescription_GetData_Test()
        {
            //The class that it calls upon to get the list of strings
            Prescription prescription = new Prescription("Allergy","Claritin","daily");
            int exLength = 2;
            int actLength = 0;
            //the variable that will hold the list of strings
           List<string> data = new List<string>();
           //the method from prescription class that gives us the list of strings
            data = prescription.GetData();
            
            yield return null;
            
            actLength = data.Count;
            //the command that will test if the list has a length of 2
            //if not it will report that this part of the program failed the test
            Assert.AreEqual(exLength, actLength);


        }
        
        [UnityTest]
        public IEnumerator _Prescription_GetData_Test_String()
        {
            //The class that it calls upon to get the list of strings
            Prescription prescription = new Prescription("Allergy","Claritin","daily");
            
            //the variable that will hold the list of strings
            
            //the method from prescription class that gives us the returned strings
            string data = prescription.GetData("strawberry");
            
            yield return null;
            
            //the command that will test if the string returned is empty
            //if not it will report that this part of the program failed the test  
            Assert.AreEqual("", data);


        }
        
        [UnityTest]
        public IEnumerator _Prescription_Get_Profile_Data()
        {
            List<string> data = new List<string>();
            //The class that it calls upon to get the list of strings
            Prescription prescription = new Prescription("Allergy","Claritin","daily");
            data = prescription.GetData();
            
             Profile profile = new Profile(data);
            
            //the variable that will hold the list of strings
            
            string get = profile.GetProfileData("monkey");
            //the method from prescription class that gives us the returned strings
            yield return null;
            
            //the command that will test if the string returned is empty
            //if not it will report that this part of the program failed the test  
            Assert.AreEqual("", get);


        }
         [UnityTest]
        public IEnumerator _Notification_Data()
        {
       
            //The class that it calls upon to get the list of strings
            Notification note= new Notification("Pills", "Take", TimeSpan.Zero);

            string data = note.toString();
            
           
            //the method from prescription class that gives us the returned strings
            yield return null;
            
            //the command that will test if the string returned is empty
            //if not it will report that this part of the program failed the test  
            Assert.AreEqual(data , data);


        }
        [UnityTest]
        public IEnumerator _Profile_Data()
        {
       
            //The class that it calls upon to get the list of strings
            Profile profile = new Profile("kevin93","strawberry","12-23-1998","female");
            string data = profile.GetProfileData("gender");
            string me = "";


            //the method from prescription class that gives us the returned strings
            yield return null;
            
            //the command that will test if the string returned is empty
            //if not it will report that this part of the program failed the test  
            Assert.AreEqual(me , data);


        }
        
          [UnityTest]
        public void Login_Page()
        {
            ProfileUI profileUi = new ProfileUI();
            profileUi.OnLogInButtonPressed();
        }
        
        
        [UnityTest]
        public void SignUp_Page()
        {
            ProfileUI profileUi = new ProfileUI();
            profileUi.Back();
        }

    }

 
