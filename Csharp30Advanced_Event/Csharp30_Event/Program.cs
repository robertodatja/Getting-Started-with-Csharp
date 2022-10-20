/* How we can use events in C-sharp?
We're going to create our own event and the event handler.
What are the events and why do we need them?
Example: 
.NET team at Microsoft launches events for developers to let them know about the latest Dot Net Framework release.
Microsoft is a publisher who launches (raises) an event and notifies the community about it.
The community is the subscriber of the event and the attends(handle) the event.
Events in C-sharp follow a similar concept and An event has - a publisher, subscriber, notification and a handler.
Generally the UI controls use events extensively.
Example:
We've events like mouse-click, maximize, etc.

On the last part, we created a delegate and the events need delegates to work.
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace Csharp30_Event
{
    public delegate void StringDelegate(string text);

    public class Program
    {
        public static void Main(string[] args)
        {
            StringDelegate strD1 = ToUpperCase; 
            WriteOutput("this is lowercase string", strD1);

            //Events
            //30.6 Create the String object
            Strings myString = new Strings(); //Strings is our new class

            //30.7 Now to this class we need to define the event & event-handler as well.
            //So whenever I set a new value to mystring object,  the TextChanged method is going to be executed.
            myString.StringEvent += TextChanged;

            //30.8
            string str;
            do
            {
                str = Console.ReadLine(); //So we want to get the text from the user - using the Console Window
                if (!str.Equals("exit") )
                    myString.Value = str;
            } while (!str.Equals("exit"));

            /*30.9 In Terminal
            If I type BERTI, I get the result  'You entered: berti' _  by using the event handler.
            So by entering a text, I trigger an event and then this event will notify the student class
            And to the student class we have subscribed by using the TextChanged method 
            And this method is used to handle the event.
            So by entering text in here, we trigger an event and if I write exit then we are out of the do-while */

        }//Main



        static void ToUpperCase(string text) => Console.WriteLine(text.ToUpper());
        static void TolowerCase(string text) => Console.WriteLine(text.ToLower());

        //30.5  Create another method which is used to handle the text change
        static void TextChanged(string text) => Console.WriteLine($"You entered: {text}");

        static void WriteOutput(string text, StringDelegate strD1)
        {
            Console.WriteLine($"\nBefore: {text}");
            strD1(text); 
        }

    }//Program




    //30.1 Create a class named Strings
    public class Strings
    {
        private string stringValue;

        /*30.2  And now inside here we need to define the event.
        To define the event we need to use the delegate that we defined from the last part. So we write: */
        public event StringDelegate StringEvent; //Create event and named StringEvent

        /*30.3  Define a property and we are going to use within this property the event that we just defined.
        Press prop&doubleTab, type string, name Value
        I'm going to remove the getter because I want to trigger the event only when I set a value to the strings object.*/
        public string Value
        {
            set
            {
                //30.4
                this.stringValue = value;
                this.StringEvent(this.stringValue);
            }
        }
    }

}//namespace