using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public static class Util
{
    public static int TryToInt(string s, int onInvalid = -1)
    {
        int x;
        return int.TryParse(s, out x) ? x : onInvalid;
    }
    
    public static string GetNewUploadFilePath()
    {
        var filename = DateTime.Now.ToString("yyMMdd-HHmmss-") +
            Guid.NewGuid().ToString().Substring(0, 8);
        return "~/Upload/" + filename;
    }
}