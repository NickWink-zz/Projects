import java.util.*;
import javax.swing.*;
public class LibraryBookSort
{
	
	public static void main(String[] args)
	{
		String user = "";
		int id;
		String titleTemp;
		String authorTemp;
		String pageTemp;
		int pageNo;
		
		
		LibraryBook[] book = new LibraryBook[5];
		/*
		book[0] = new LibraryBook("Title123421", "Author", 14);
		book[1] = new LibraryBook("Title1", "Aut", 14);
		book[2] = new LibraryBook("Title4", "hor", 14);
		book[3] = new LibraryBook("Title3", "thor", 14);
		book[4] = new LibraryBook("Title532312", "Autr", 14);
		*/
		for(int i = 0; i < 5; i++)
		{
			
			titleTemp = JOptionPane.showInputDialog(null, "Please enter Title");
			authorTemp = JOptionPane.showInputDialog(null, "Please enter Author");
			pageTemp = JOptionPane.showInputDialog(null, "Please enter Page Number");
			
			pageNo = Integer.parseInt(pageTemp);
			//book[i] = new LibraryBook(titleTemp, authorTemp, pageTemp);
			book[i] = new LibraryBook(titleTemp, authorTemp, pageNo);
		}
		
		user = JOptionPane.showInputDialog(null, "Select how you wish to sort your books. \n [1]Title, [2]Author, [3]Page Number ");
		
		id = Integer.parseInt(user);
		
		switch(id)
		{
			case 1: //title
				System.out.println("One");
				TitleSort(book);
			
			case 2: //author
				System.out.println("Two");
				AuthorSort(book);
			case 3:
				System.out.println("Three");
				PageSort(book);
		}
		for(int i = 0; i < 5; i++)
		{
			System.out.println(book[i].getTitle());
		//System.out.println(bookAuthor);
		//System.out.println(pageCount);
		}

	}
	
	public static void TitleSort(LibraryBook[] array)
	{	
	
		int a, b;
		LibraryBook temp;
		
		int highSubscript = array.length - 1;
		for(a = 0; a < highSubscript; ++a)
		for(b = 0; b < highSubscript; ++b)
			if(array[b].getTitle().compareTo(array[b+1].getTitle())>0)
			{
				temp = array[b];
				array[b] = array[b + 1];
				array[b + 1] = temp;
			}
		
		
	}
	
	public static void AuthorSort(LibraryBook[] array)
	{	
		int a, b;
		LibraryBook temp;
		
		int highSubscript = array.length - 1;
		for(a = 0; a < highSubscript; ++a)
		for(b = 0; b < highSubscript; ++b)
			if(array[b].getAuthor().compareTo(array[b+1].getAuthor())>0)
			{
				temp = array[b];
				array[b] = array[b + 1];
				array[b + 1] = temp;
			}
			
		
	}
	
	public static void PageSort(LibraryBook[] array)
	{	
	
		
		int a, b;
		LibraryBook temp;
		
		int highSubscript = array.length - 1;
		for(a = 0; a < highSubscript; ++a)
		for(b = 0; b < highSubscript; ++b)
			if(array[b].getPageCount() > array[b+1].getPageCount())
			{
				temp = array[b];
				array[b] = array[b + 1];
				array[b + 1] = temp;
			}
		
	}
}