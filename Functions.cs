using System;

namespace TherraxSafeHtmlPackage
{
    public static class Functions
    {
        public static bool IsHTMLSafe(string s)
        {
            //html5 events
            if (s.Contains("onafterprint=")) return false;
            if (s.Contains("onbeforeprint=")) return false;
            if (s.Contains("onbeforeunload=")) return false;
            if (s.Contains("onerror=")) return false;
            if (s.Contains("onhashchange=")) return false;
            if (s.Contains("onmessage=")) return false;
            if (s.Contains("onoffline=")) return false;
            if (s.Contains("ononline=")) return false;
            if (s.Contains("onpagehide=")) return false;
            if (s.Contains("onpageshow=")) return false;
            if (s.Contains("onpopstate=")) return false;
            if (s.Contains("onresize=")) return false;
            if (s.Contains("onstorage=")) return false;
            if (s.Contains("onunload=")) return false;
            if (s.Contains("onclick=")) return false;

            //html events
            if (s.Contains("abort=")) return false;
            if (s.Contains("afterprint=")) return false;
            if (s.Contains("animationend=")) return false;
            if (s.Contains("animationiteration=")) return false;
            if (s.Contains("animationstart=")) return false;
            if (s.Contains("beforeprint=")) return false;
            if (s.Contains("beforeunload=")) return false;
            if (s.Contains("blur=")) return false;
            if (s.Contains("canplay=")) return false;
            if (s.Contains("canplaythrough=")) return false;
            if (s.Contains("change=")) return false;
            if (s.Contains("click=")) return false;
            if (s.Contains("contextmenu=")) return false;
            if (s.Contains("copy=")) return false;
            if (s.Contains("cut=")) return false;
            if (s.Contains("dblclick=")) return false;
            if (s.Contains("drag=")) return false;
            if (s.Contains("dragend=")) return false;
            if (s.Contains("dragenter=")) return false;
            if (s.Contains("dragleave=")) return false;
            if (s.Contains("dragover=")) return false;
            if (s.Contains("dragstart=")) return false;
            if (s.Contains("dragstart=")) return false;
            if (s.Contains("drop=")) return false;
            if (s.Contains("durationchange=")) return false;
            if (s.Contains("ended=")) return false;
            if (s.Contains("error=")) return false;
            if (s.Contains("focus=")) return false;
            if (s.Contains("focusin=")) return false;
            if (s.Contains("focusout=")) return false;
            if (s.Contains("fullscreenchange=")) return false;
            if (s.Contains("fullscreenerror =")) return false;
            if (s.Contains("hashchange=")) return false;
            if (s.Contains("input=")) return false;
            if (s.Contains("invalid=")) return false;
            if (s.Contains("keydown=")) return false;
            if (s.Contains("keypress=")) return false;
            if (s.Contains("keyup=")) return false;
            if (s.Contains("load=")) return false;
            if (s.Contains("loadeddata=")) return false;
            if (s.Contains("loadedmetadata=")) return false;
            if (s.Contains("loadstart=")) return false;
            if (s.Contains("message=")) return false;
            if (s.Contains("mousedown=")) return false;
            if (s.Contains("mouseenter=")) return false;
            if (s.Contains("mouseleave=")) return false;
            if (s.Contains("mousemove=")) return false;
            if (s.Contains("mouseover=")) return false;
            if (s.Contains("mouseout=")) return false;
            if (s.Contains("mouseup=")) return false;
            if (s.Contains("mousewheel=")) return false;
            if (s.Contains("offline=")) return false;
            if (s.Contains("online=")) return false;
            if (s.Contains("open=")) return false;
            if (s.Contains("pagehide=")) return false;
            if (s.Contains("pageshow=")) return false;
            if (s.Contains("paste=")) return false;
            if (s.Contains("pause=")) return false;
            if (s.Contains("play=")) return false;
            if (s.Contains("playing=")) return false;
            if (s.Contains("popstate=")) return false;
            if (s.Contains("progress=")) return false;
            if (s.Contains("ratechange=")) return false;
            if (s.Contains("resize=")) return false;
            if (s.Contains("reset=")) return false;
            if (s.Contains("scroll=")) return false;
            if (s.Contains("search=")) return false;
            if (s.Contains("seeked=")) return false;
            if (s.Contains("seeking=")) return false;
            if (s.Contains("select=")) return false;
            if (s.Contains("show=")) return false;
            if (s.Contains("stalled=")) return false;
            if (s.Contains("storage=")) return false;
            if (s.Contains("submit=")) return false;
            if (s.Contains("suspend=")) return false;
            if (s.Contains("timeupdate=")) return false;
            if (s.Contains("toggle=")) return false;
            if (s.Contains("touchcancel=")) return false;
            if (s.Contains("touchend=")) return false;
            if (s.Contains("touchmove=")) return false;
            if (s.Contains("touchstart=")) return false;
            if (s.Contains("transitionend=")) return false;
            if (s.Contains("unload=")) return false;
            if (s.Contains("volumechange=")) return false;
            if (s.Contains("waiting=")) return false;
            if (s.Contains("wheel=")) return false;

            //illegal tags
            if (s.Contains("<img")) return false;
            if (s.Contains("<font")) return false;
            if (s.Contains("<iframe")) return false;
            if (s.Contains("<embed")) return false;
            if (s.Contains("<audio")) return false;
            if (s.Contains("<video")) return false;

            //illegal adding script and styles
            if (s.Contains("<style")) return false;
            if (s.Contains("<script")) return false;
            if (s.Contains("style="))
            {
                if(s.Contains("background")) return false;
            }
            

            return true;
        }
    } 
}
