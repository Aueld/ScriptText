    // 폰트가 점점 커지는 매서드
    void bigFontMethod(string[] mStr)
    {
        string dstr = "";
        for (int i = 0; i < mStr[nowline].Length; i++)
        {
            if (isScroll && nowline == startline)
            {
                if (isFontBig)
                {
                    dstr += "<size=" + bigFont.ToString() + ">";
                }
                dstr += mStr[nowline][i];
                if (isFontBig)
                {
                    dstr += "</size>";
                }
                bigFont++;
            }
        }
        tx_Text.text = dstr;
    }
