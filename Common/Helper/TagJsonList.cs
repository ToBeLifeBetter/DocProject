using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helper
{
    public class TagJsonList
    {
        int firstId = 1;
        int secendId = 101;
        int thridId = 1001;


        //public string GetJson(List<TagContentListModel> tagContentListModels)
        //{

        //    StringBuilder sb = new StringBuilder();

        //    //第一级
        //    sb.Append(" [");
        //    int count = 1;
        //    foreach (var item in tagContentListModels)
        //    {
      
        //        sb.Append(" {");
        //        sb.Append("title:");
        //        sb.Append("\'" + item.TagFatherName + "\'");
        //        sb.Append(",");

        //        sb.Append("id:");
        //        sb.Append( firstId++);
        //        sb.Append(",");
        //        if (firstId == 2)
        //            sb.Append("spread:true");
        //        else
        //        sb.Append("spread:false");
        //        if (item.TagSonModel.Count != 0)
        //        {
        //            int onecount = 1;
        //            sb.Append(",children:[");
        //            foreach (var itemson in item.TagSonModel)
        //            {
        //                sb.Append(" {");

        //                sb.Append("title : ");
        //                sb.Append("\'" + itemson.TagSonName + "\'");
        //                sb.Append(",");

        //                sb.Append("id:");
        //                sb.Append( secendId++);
        //                sb.Append(",");
        //                if (secendId == 102)
        //                    sb.Append("spread:true");
        //                else
        //                sb.Append("spread:false");
        //                if (itemson.TagBehaviorList.Count != 0)
        //                {
        //                    int seccount = 1;
        //                    sb.Append(",children:[");
        //                    foreach (var havior in itemson.TagBehaviorList)
        //                    {
        //                        sb.Append(" {");
        //                        sb.Append("title : ");
        //                        sb.Append("\'" + havior.Name + "\'");
        //                        sb.Append(",");
        //                        sb.Append("id:");
        //                        sb.Append(thridId++);
        //                        sb.Append(",");
        //                        sb.Append("href:");
        //                        sb.Append("\'" + "/DocumentList/DocPage?01.html简介-01.课前预习.html"+ "\'");
        //                        sb.Append("}");
        //                        if (itemson.TagBehaviorList.Count != seccount && itemson.TagBehaviorList.Count != 0)
        //                            sb.Append(",");
        //                        //else
        //                        //    sb.Append("}");
        //                        ++seccount;
        //                    }
        //                    sb.Append("]");
        //                }
                      
        //                sb.Append(" }");
        //                if (itemson.TagBehaviorList.Count != onecount && itemson.TagBehaviorList.Count != 0)
        //                    sb.Append(",");
        //                else
        //                    sb.Append(" }");
        //                ++onecount;

                       
        //            }
                  
        //            sb.Append("]");
        //        }



        //       if(tagContentListModels.Count!= count )
        //        sb.Append(" },");
        //       else
        //            sb.Append(" }");
        //        count++;
        //    }
 
        //    sb.Append("]");
        //    return sb.ToString();
        //}

        

    }
}
