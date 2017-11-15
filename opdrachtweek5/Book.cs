public class Book: Author{
    private string name;
    private Author author;
    private double price;
    private int qtyInStock = 0;
    
    public Book (string name, Author author, double price, int qtyInStock){
        this.name = name;
        this.author = author;
        this.price = price;
        this.qtyInStock = qtyInStock;
    }

    public string getName() {
        return this.name;
    }
    public Author author(){
        return this.author;
    }

    public double Price { get => price ; set => price = value;}
    public int QtyInStock { get => qtyInStock ; set => qtyInStock = value;}
    public string getAuthorName(){
        return this.Author.name;
    }

}