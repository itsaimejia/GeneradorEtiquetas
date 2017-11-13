using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.Collections;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Windows.Forms;

namespace GeneradorEtiquetas
{
	class Generador
	{
		static object oMissing = Missing.Value;
		static object oEndOfDoc = "\\endofdoc";
		static Word._Application AplicacionWord;
		static Word._Document Documento;
		public List<Modelo> ITEMS = new List<Modelo>();

		public void Eliminar(string itemEsp)
		{
			foreach(var item in ITEMS)
			{
				if (item.Item == itemEsp)
				{
					ITEMS.Remove(item);
					break;
				}
			}
		}

		public void ElimiarITEMS()
		{
			foreach(var item in ITEMS)
			{
				ITEMS.Remove(item);
			}
		}

		public void EtiquetaPrecio()
		{
			AplicacionWord = new Word.Application();
			AplicacionWord.Visible = true;
			Documento = AplicacionWord.Documents.Add(ref oMissing, ref oMissing,
			ref oMissing, ref oMissing);
			var doc = Documento.PageSetup;
			doc.TopMargin = AplicacionWord.CentimetersToPoints(1);
			doc.LeftMargin = AplicacionWord.CentimetersToPoints(0);
			doc.BottomMargin = AplicacionWord.CentimetersToPoints(0);
			doc.RightMargin = AplicacionWord.CentimetersToPoints(0);
			Word.Table oTable;
			Word.Range wrdRng = Documento.Bookmarks.get_Item(ref oEndOfDoc).Range;
			oTable = Documento.Tables.Add(wrdRng, 10, 3, ref oMissing, ref oMissing);
			int i = 0;
			
			for (int r = 1; r <= 10; r++)
			{
				for (int c = 1; c <= 3; c++)
				{
					try
					{
						oTable.Cell(r, c).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
						oTable.Cell(r, c).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
						oTable.Cell(r, c).Range.Text = $"Style number {ITEMS[i].Item}\n${ITEMS[i].Price:0.00} pk/ {ITEMS[i].Pack}";
						oTable.Cell(r, c).Range.Font.Size = 14;
						oTable.Cell(r, c).Range.Font.Bold = 1;
						oTable.Cell(r, c).Range.Font.Italic = 2;
						oTable.Cell(r, c).Range.Font.Name = "Adobe Caslon Pro";
						oTable.Columns[c].Width = AplicacionWord.CentimetersToPoints(7);
						i++;
					}
					catch (Exception)
					{

					}
				}
				oTable.Rows[r].Height = AplicacionWord.InchesToPoints(1);
			}
		}

		public void EtiquetaColeccion()
		{
			AplicacionWord = new Word.Application();
			AplicacionWord.Visible = true;
			Documento = AplicacionWord.Documents.Add(ref oMissing, ref oMissing,
			ref oMissing, ref oMissing);
			var doc = Documento.PageSetup;
			doc.TopMargin = AplicacionWord.CentimetersToPoints(1);
			doc.LeftMargin = AplicacionWord.CentimetersToPoints(0);
			doc.BottomMargin = AplicacionWord.CentimetersToPoints(0);
			doc.RightMargin = AplicacionWord.CentimetersToPoints(0);
			Word.Table oTable;
			Word.Range wrdRng = Documento.Bookmarks.get_Item(ref oEndOfDoc).Range;
			oTable = Documento.Tables.Add(wrdRng, 10, 3, ref oMissing, ref oMissing);
			int i = 0;
			for (int r = 1; r <= 10; r++)
			{
				for (int c = 1; c <=3; c++)
				{

					try
					{
						oTable.Cell(r, c).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
						oTable.Cell(r, c).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
						oTable.Cell(r, c).Range.Text = $"{ITEMS[i].Collection}\n{ITEMS[i].Item}";
						oTable.Cell(r, c).Range.Font.Size = 20;
						oTable.Cell(r, c).Range.Font.Bold = 1;
						oTable.Cell(r, c).Range.Font.Name = "Arial";
						oTable.Columns[c].Width = AplicacionWord.CentimetersToPoints(7);
						i++;
					}
					catch (Exception)
					{

					}
				}
				oTable.Rows[r].Height = AplicacionWord.InchesToPoints(1);
			}
		}
	}
}
