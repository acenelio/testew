using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context) 
        {
            _context = context;
        }

        public void Seed()
        {
            //operação responsavel por popular a base de dados
            if(_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;//banco de dados já preenchido
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            Seller s3 = new Seller(3, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            Seller s4 = new Seller(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            Seller s5 = new Seller(5, "Donald Blue", "donald@gmail", new DateTime(2000, 1, 9), 4000.0, d3);
            Seller s6 = new Seller(6, "Alex Pink", "alex@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 9, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 9, 01), 12000.0, SaleStatus.Pending, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 8, 25), 8000.0, SaleStatus.Pending, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 1, 05), 10000.0, SaleStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2018, 1, 21), 9000.0, SaleStatus.Pending, s5);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2018, 1, 15), 8200.0, SaleStatus.Pending, s6);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2018, 7, 10), 11500.0, SaleStatus.Pending, s1);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2018, 9, 03), 11700.0, SaleStatus.Pending, s2);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2018, 9, 30), 10500.0, SaleStatus.Billed, s3);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2018, 6, 06), 11200.0, SaleStatus.Pending, s4);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2018, 9, 12), 14000.0, SaleStatus.Billed, s5);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2018, 9, 01), 8000.0, SaleStatus.Pending, s6);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2018, 9, 04), 14100.0, SaleStatus.Billed, s1);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2018, 9, 07), 13200.0, SaleStatus.Billed, s2);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2018, 12, 11), 10250.0, SaleStatus.Billed, s3);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2018, 9, 11), 12230.0, SaleStatus.Pending, s4);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2018, 11, 25), 10050.7, SaleStatus.Pending, s5);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2018, 9, 02), 20000.0, SaleStatus.Billed, s6);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2018, 8, 29), 18000.0, SaleStatus.Billed, s1);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2018, 5, 25), 15000.0, SaleStatus.Billed, s2);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2018, 12, 05), 13000.0, SaleStatus.Billed, s3);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2018, 10, 25), 14000.0, SaleStatus.Pending, s4);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2018, 4, 22), 12400.0, SaleStatus.Billed, s5);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2018, 4, 18), 11750.0, SaleStatus.Billed, s6);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2018, 10, 25), 19000.0, SaleStatus.Billed, s1);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2018, 8, 16), 18750.0, SaleStatus.Pending, s2);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2018, 12, 12), 17753.0, SaleStatus.Billed, s3);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2018, 3, 31), 11000.0, SaleStatus.Billed, s6);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2018, 3, 10), 10000.0, SaleStatus.Pending, s5);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2018, 9, 30), 12000.0, SaleStatus.Billed, s4);

            //Adicionando no banco de dados
            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15,
                                        r16, r17, r18, r19, r20, r21, r22, r23, r24, r25, r26, r27, r28, r29, r30);

            //efetuando as alterações no banco de dados
            _context.SaveChanges();
        }
    }
}