using System;
using System.Collections.Generic;

class NoOggyChecker
{
  static void RemoveOggy(List<string> names)
  {
    names.RemoveAll(item => item.StartsWith("oggy"));      //RemoveAll method using Lambda function will remove all strings starting with "oggy" 
  }
  static bool OggyIsRemoved(List<string> names)
  {
    return names.Find(x => x.Contains("oggy")) == null;
  }
  static int Main()
  {
    var names = new List<string>
      { "nobita", "bheem", "oggy", "oggy cockroach", "ninja" };
    RemoveOggy(names);
    if(OggyIsRemoved(names)) {
      Console.WriteLine("Passed!");
      return 0;
    } else {
      Console.WriteLine("Failed!!");
      return 1;
    }
  }
}