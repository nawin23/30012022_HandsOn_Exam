using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookRecomendationDTO;

namespace BookRecomendationDataAccessLayer
{
    //DO NOT MODIFY THE METHOD NAMES : Adding of parameters / changing the return types of the given methods may be required.
    public class BookRecomendationDAL
    {
        BookRecomendationContext ContextObj;

        public BookRecomendationDAL()
        {
            ContextObj = new BookRecomendationContext();



        public List<BookDTO> FetchReviewsForBook()
        {
                try
                {
                    var Result = ContextObj.Reviews.ToList();
                    List<BookDTO> bookdto = new List<BookDTO>();
                    foreach (var Reviews in Result)
                    {
                        bookdto.Add(new BookDTO()
                        {
                           BookID=Convert.ToInt32 (Reviews.book_isbn),
                           Rating=Convert.ToInt32 (Reviews.rating),
                           Review=Reviews.review1,


                        });
                        
                    }
                    return bookdto;
                }

                catch (Exception ex)
                {
                    throw;
                }
            }

        }

        public void SaveReviewForBookToDB()
        {

        }

     }
}
