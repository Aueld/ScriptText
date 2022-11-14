    void TextEvent(List<Dictionary<string, object>> dataList,int eID)
    {
        mEventNode = new List<Node>();
        for (var i = 0; i < dataList.Count; i++)
        {
            string CheckStr = dataList[i]["EventID"].ToString();
            int CheckID = int.Parse(CheckStr);

            if (CheckID == eID)
            {
                mEventNode.Add(new Node(dataList[i]["Name"].ToString(), dataList[i]["SubName"].ToString(),
                    (int)dataList[i]["FontSize"], dataList[i]["Text"].ToString(),
                    (int)dataList[i]["LC"], dataList[i]["LE"].ToString(), (int)dataList[i]["LA"], (int)dataList[i]["RC"],
                    dataList[i]["RE"].ToString(), (int)dataList[i]["RA"], (int)dataList[i]["Background"],
                    (int)dataList[i]["BGM"], (int)dataList[i]["bgEffect"], dataList[i]["Voice"].ToString(), (int)dataList[i]["SFX"],
                    (int)dataList[i]["EventID"],
                    (int)dataList[i]["TextNum"], (int)dataList[i]["CG"], (int)dataList[i]["LRT"]));
            }
        }

        maxTextNum = mEventNode.Count;
        str_scripts = new string[maxTextNum];
        for (int i = 0; i < maxTextNum; i++)
        {
            str_scripts[i] = mEventNode[i].Text;
        }
    }
