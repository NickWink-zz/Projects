import java.util.*;
public class LibraryBook
{
	//title //author //page count
	
	private String bookTitle;
	private String bookAuthor;
	private int pageCount;
	
	public LibraryBook()
	{
	}
	
	public LibraryBook(String title, String Author, int count)
	{
	  bookTitle = title;
	  bookAuthor = Author;
	  pageCount = count;
	}
	
	public String getTitle()
	{
		return bookTitle;
	}
	
	public void setTitle(String title)
	{
		bookTitle = title;
	}
	
	public String getAuthor()
	{
		return bookAuthor;
	}
	
	public void setAuthor(String author)
	{
		bookAuthor = author;
	}
	
	public int getPageCount()
	{
		return pageCount;
	}
	
	public void setPageCount(int count)
	{
		pageCount = count;
	}
	
	
	
}