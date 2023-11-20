using System.Collections.Generic;
using System.Linq;
using BackEnd_Ciberpunk2099.Models;
using Microsoft.EntityFrameworkCore;

public class ProductRepository
{
    private readonly CiberPunk2099Context _context;

    public ProductRepository(CiberPunk2099Context context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        return await _context.Products.ToListAsync();
    }

    public async Task<Product> GetProductByIdAsync(int productId)
    {
        return await _context.Products.FindAsync(productId);
    }

    public async Task AddProductAsync(Product product)
    {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateProductAsync(Product product)
    {
        _context.Entry(product).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteProductAsync(int productId)
    {
        var product = await _context.Products.FindAsync(productId);
        if (product != null)
        {
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }
    }

    internal async Task<List<Product>> GetProductsAsync()
    {
        return await _context.Products.ToListAsync();
    }

    internal async Task CreateProductAsync(Product product)
    {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
    }

    internal async Task UpdateProductAsync(int productId, Product updatedProduct)
    {
        var existingProduct = await _context.Products.FindAsync(productId);

        if (existingProduct != null)
        {
            existingProduct.Title = updatedProduct.Title;
            existingProduct.Description = updatedProduct.Description;
            existingProduct.Price = updatedProduct.Price;
            existingProduct.Category = updatedProduct.Category;

            await _context.SaveChangesAsync();
        }
    }
}
