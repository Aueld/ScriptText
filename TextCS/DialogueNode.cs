using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class DialogueNode : MonoBehaviour
{

}

public class Node
{
    public string Name;
    public string SubName;
    public int FontSize;
    public string Text;
    public int LC;
    public string LE;
    public int LA;
    public int RC;
    public string RE;
    public int RA;
    public int Background;
    public int BGM;
    public int bgEffect;
    public string Voice;
    public int SFX;
    public int EventID;
    public int TextNum;
    public int CG;
    public int LRT;

    public Node(string name,string subname, int fontsize, string text, int lc, string le, int la, int rc, string re, int ra, int background, int bgm, int bgeffect, string voice, int sfx, int eventid, int textnum, int cg, int lrt)
    {
        this.Name = name;
        this.SubName = subname;
        this.FontSize = fontsize;
        this.Text = text;
        this.LC = lc;
        this.LE = le;
        this.LA = la;
        this.RC = rc;
        this.RE = re;
        this.RA = ra;
        this.Background = background;
        this.BGM = bgm;
        this.bgEffect = bgeffect;
        this.Voice = voice;
        this.SFX = sfx;
        this.EventID = eventid;
        this.TextNum = textnum;
        this.CG = cg;
        this.LRT = lrt;
    }
}
