using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookRecomendationDataAccessLayer;
using BookRecomendationDTO;

namespace BookRecomendationBusinessLayer
{
    //DO NOT MODIFY THE METHOD NAMES : Adding of parameters / changing the return types of the given methods may be required. 
    public class BookRecomendationBL
    {
        BookRecomendationContext ContextObj;

       

        public void ShowReviewsForBook()
        {
            BookRecomendationDAL dalObj=new BookRecomendationDAL();
            return dalObj.FetchReviewsForBook();
        }


        public void AddReviewForBook()
        {
          
        }
      
    }
}
