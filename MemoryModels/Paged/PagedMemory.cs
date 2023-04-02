using System;
using System.Collections.Generic;
using System.Linq;

namespace DAT.Model.Paged
{
    public class PagedMemory
    {
        public readonly int pageSize;
        public readonly int memorySize;

        private readonly List<Page> pages = new List<Page>();
        private readonly Page[] primary;
        private readonly List<Page> secondary = new List<Page>();

        private readonly Random rand;

        public IEnumerable<Page> Pages => pages;
        public IEnumerable<Page> Primary => primary;
        public IEnumerable<Page> Secondary => secondary;

        public int FramesCount => primary.Length;

        public PagedMemory(int pageSize, int framesCount, int memorySize)
        {
            if (pageSize <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(pageSize), "below or equal zero!");
            }
            if (memorySize <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(memorySize), "below of equal zero!");
            }
            if (framesCount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(framesCount), "below of equal zero!");
            }

            this.pageSize = pageSize;
            this.memorySize = memorySize;

            primary = new Page[framesCount];

            rand = new Random();
        }

        public void AddPage(Page page)
        {
            if (pages.Contains(page))
            {
                throw new Exceptions.PageAlreadyExistsException();
            }

            if (page.InPrimary)
            {
                AddInPrimary(page);
            }
            else
            {
                AddInSecondary(page);
            }

            pages.Add(page);
        }

        public void UpdatePage(Id id)
        {
            var index = pages.FindIndex(p => p.Id == id);

            if (index < 0)
            {
                throw new Exceptions.PageNotExistsException();
            }

            UpdatePage(index);
        }

        public void RemovePage(Page page)
        {
            if (!pages.Contains(page))
            {
                throw new Exceptions.PageNotExistsException();
            }

            if (page.InPrimary)
            {
                RemoveFromPrimary(page);
            }
            else
            {
                secondary.Remove(page);
            }

            pages.Remove(page);
        }

        public int TranslateAddress(int pageIndex, int pageDelta)
        {
            if (pageDelta < 0 || pageDelta >= pageSize)
            {
                throw new ArgumentOutOfRangeException(nameof(pageIndex), "out of range");
            }

            // Ищем страницу
            var page = pages.Find(p => p.Id == pageIndex);
            if (page == null)
            {
                throw new Exceptions.PageNotExistsException();
            }

            // Если страница в первичной памяти
            if (page.InPrimary)
            {
                return page.Frame * pageSize + pageDelta;
            }

            // Загрузка в свободный фрейм
            var frame = PickFreeFrame();
            if (frame >= 0)
            {
                page.Load(frame);
                UpdatePage(page.Id);

                return page.Frame * (int)pageSize + (int)pageDelta;
            }

            // Освобождаем случайный фрейм в первичной памяти
            var randFrame = rand.Next(primary.Length);
            // Меняем местами страницы из первичной и вторичной памяти
            SwapPages(primary[randFrame], page);

            return page.Frame * (int)pageSize + (int)pageDelta;
        }

        public Tuple<int, int> TranslateAddress(uint realAddr)
        {
            if (realAddr < 0 || realAddr >= primary.Length * pageSize)
            {
                throw new System.ArgumentOutOfRangeException("Incorrect address!");
            }

            var p = (int)(realAddr / pageSize);
            var d = (int)(realAddr % pageSize);

            if (pages[p] == null)
            {
                p = -1;
            }
            
            return new Tuple<int, int>(p, d);
        }

        private void UpdatePage(int index)
        {
            var page = pages[index];

            if (page.InPrimary)
            {
                AddInPrimary(page);
            }
            else
            {
                AddInSecondary(page);
            }
        }

        private void AddInPrimary(Page page)
        {
            if (page.Frame < 0 || page.Frame >= primary.Length)
            {
                throw new Exceptions.OutOfFramesException();
            }
            
            if (primary.Any(p => p != null && p.Frame == page.Frame))
            {
                throw new System.ArgumentException("Заданный фрейм занят!");
            }

            primary[page.Frame] = page;
        }

        private void RemoveFromPrimary(Page page)
        {
            if (page.Frame < 0 || page.Frame <= primary.Length)
            {
                throw new System.ArgumentException("Incorrect page!");
            }

            primary[page.Frame] = null;
        }

        private void AddInSecondary(Page page)
        {
            var minAddr = page.Address;
            var maxAddr = minAddr + pageSize;

            if (minAddr < 0 || maxAddr >= memorySize)
            {
                throw new Exceptions.OutOfMemoryException();
            }

            foreach (var mPage in secondary)
            {
                var mMax = mPage.Address + pageSize;

                if (mMax > minAddr && mMax <= maxAddr)
                {
                    throw new System.ArgumentException("Заданный адрес занят!");
                }
            }

            secondary.Add(page);
        }

        private int PickFreeFrame()
        {
            for (var i = 0; i < primary.Length; i++)
            {
                if (primary[i] != null)
                {
                    continue;
                }

                return i;
            }

            return -1;
        }

        //private int PickFreeAddress()
        //{
        //    var startAddr = secondary.Select(x => x.Address).ToList();
        //    startAddr.Sort();

        //    var addr = 0;
        //    while (addr  && addr < memorySize)

        //}
        
        private void SwapPages(Page page1, Page page2)
        {
            if (!pages.Contains(page1) || !pages.Contains(page2))
            {
                throw new Exceptions.PageNotExistsException();
            }

            // TODO
            throw new NotImplementedException();
        }
    }
}
