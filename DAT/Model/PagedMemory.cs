using System.Collections.Generic;
using System.Linq;

namespace DAT.Model
{
    public class PagedMemory
    {
        private readonly int pageSize;
        private readonly int framesCount;
        private readonly int memorySize;

        private readonly List<Page> pages;
        private readonly List<Page> primary;
        private readonly List<Page> secondary;

        public IReadOnlyList<Page> Pages => pages;
        public IReadOnlyList<Page> Primary => primary;
        public IReadOnlyList<Page> Secondary => secondary;

        public void AddPage(Page page)
        {
            if (!pages.Contains(page))
            {
                throw new System.ArgumentException("Page already exists!");
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
            // TODO
        }

        public void RemovePage(Page page)
        {
            if (!pages.Contains(page))
            {
                throw new System.ArgumentException("Page already exists!");
            }

            if (page.InPrimary)
            {
                primary.Remove(page);
            }
            else
            {
                secondary.Remove(page);
            }
        }

        private void AddInPrimary(Page page)
        {
            if (page.Frame > framesCount)
            {
                throw new System.ArgumentOutOfRangeException("Не хватает фреймов!");
            }
            
            if (primary.Any(p => p.Frame == page.Frame))
            {
                throw new System.ArgumentException("Заданный фрейм занят!");
            }

            primary.Add(page);
        }

        private void AddInSecondary(Page page)
        {
            var minAddr = page.Address;
            var maxAddr = minAddr + pageSize;

            if (maxAddr > memorySize)
            {
                throw new System.ArgumentOutOfRangeException("Не хватает памяти!");
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
    }
}
