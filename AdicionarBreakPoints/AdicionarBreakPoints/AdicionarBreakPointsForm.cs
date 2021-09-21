using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AdicionarBreakPoints
{
	public partial class AdicionarBreakPointsForm : Form
    {
        private string arquivoXML = "ArquivoBreakPoints.xml";

        public AdicionarBreakPointsForm()
        {
            InitializeComponent();
        }

        private void GerarXmlButton_Click(object sender, EventArgs e)
        {
            try
            {
                var caminhoFontes = CaminhoProjetoTextBox.Text;
                var palavra = PalavraBuscaTextBox.Text;

                if (File.Exists(arquivoXML))
                {
                    File.Delete(arquivoXML);
                }

                File.Create(arquivoXML).Close();

                EscreverArquivo("<?xml version='1.0' encoding='utf-8'?>");
                EscreverArquivo("<BreakpointCollection xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xmlns:xsd='http://www.w3.org/2001/XMLSchema'>");
                EscreverArquivo("   <Breakpoints>");

                if (string.IsNullOrEmpty(caminhoFontes))
                {
                    throw new Exception("Informe o caminho dos arquivos!");
                }

                if (string.IsNullOrEmpty(palavra))
                {
                    throw new Exception("Informe a palavra que deseja buscar!");
                }

                var arquivos = Directory.GetFiles(caminhoFontes, "*.cs", SearchOption.AllDirectories);

                foreach (var arquivo in arquivos)
                {
                    var nrLinha = 0;

                    using (var str = new StreamReader(arquivo))
                    {
                        while (!str.EndOfStream)
                        {
                            var linha = str.ReadLine();

                            if (linha.Contains(palavra))
                            {
                                AdicionarBreakPoint(arquivo, nrLinha, palavra);
                            }

                            nrLinha++;
                        }
                    }
                }

                EscreverArquivo("   </Breakpoints>");
                EscreverArquivo("</BreakpointCollection>");

				MessageBox.Show("Arquivo Gerado com sucesso");
                Process.Start(Environment.CurrentDirectory);
			}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EscreverArquivo(string conteudo)
        {
            using (var stw = new StreamWriter(arquivoXML, true))
            {
                stw.WriteLine(conteudo);
            }
        }

        private void AdicionarBreakPoint(string nomeArquivo, int nrLinha, string textoLinha)
        {
            using (var stw = new StreamWriter(arquivoXML, true))
            {
                stw.WriteLine("<Breakpoint>");
                stw.WriteLine("  <Version>15</Version>");
                stw.WriteLine("  <IsEnabled>1</IsEnabled>");
                stw.WriteLine("  <IsVisible>1</IsVisible>");
                stw.WriteLine("  <IsEmulated>0</IsEmulated>");
                stw.WriteLine("  <IsCondition>0</IsCondition>");
                stw.WriteLine("  <IsProductionBps>0</IsProductionBps>");
                stw.WriteLine("  <ConditionType>WhenTrue</ConditionType>");
                stw.WriteLine("  <LocationType>SourceLocation</LocationType>");
                stw.WriteLine("  <TextPosition>");
                stw.WriteLine("	<Version>4</Version>");
                stw.WriteLine($@"	<FileName>{nomeArquivo}</FileName>");
                stw.WriteLine($"	<startLine>{nrLinha}</startLine>");
                stw.WriteLine("	<StartColumn>1</StartColumn>");
                stw.WriteLine($"	<EndLine>{nrLinha}</EndLine>");
                stw.WriteLine("	<EndColumn>1</EndColumn>");
                stw.WriteLine("	<MarkerId>0</MarkerId>");
                stw.WriteLine("	<IsLineBased>0</IsLineBased>");
                stw.WriteLine("	<IsDocumentPathNotFound>0</IsDocumentPathNotFound>");
                stw.WriteLine("	<ShouldUpdateTextSpan>1</ShouldUpdateTextSpan>");
                stw.WriteLine("	<Checksum>");
                stw.WriteLine("	  <Version>1</Version>");
                stw.WriteLine("	  <Algorithm>00000000-0000-0000-0000-000000000000</Algorithm>");
                stw.WriteLine("	  <ByteCount>0</ByteCount>");
                stw.WriteLine("	  <Bytes />");
                stw.WriteLine("	</Checksum>");
                stw.WriteLine("  </TextPosition>");
                stw.WriteLine("  <NamedLocationText></NamedLocationText>");
                stw.WriteLine("  <NamedLocationLine>2</NamedLocationLine>");
                stw.WriteLine("  <NamedLocationColumn>0</NamedLocationColumn>");
                stw.WriteLine("  <HitCountType>NoHitCount</HitCountType>");
                stw.WriteLine("  <HitCountTarget>1</HitCountTarget>");
                stw.WriteLine("  <Language>3f5162f8-07c6-11d3-9053-00c04fa302a1</Language>");
                stw.WriteLine("  <IsMapped>0</IsMapped>");
                stw.WriteLine("  <BreakpointType>PendingBreakpoint</BreakpointType>");
                stw.WriteLine("  <AddressLocation>");
                stw.WriteLine("	<Version>0</Version>");
                stw.WriteLine("	<MarkerId>0</MarkerId>");
                stw.WriteLine("	<FunctionLine>0</FunctionLine>");
                stw.WriteLine("	<FunctionColumn>0</FunctionColumn>");
                stw.WriteLine("	<Language>00000000-0000-0000-0000-000000000000</Language>");
                stw.WriteLine("  </AddressLocation>");
                stw.WriteLine("  <DataCount>4</DataCount>");
                stw.WriteLine("  <IsTracepointActive>0</IsTracepointActive>");
                stw.WriteLine("  <TracepointTargetType>VsOutputWindow</TracepointTargetType>");
                stw.WriteLine("  <TimeTravelTraceMarker>NoTracing</TimeTravelTraceMarker>");
                stw.WriteLine("  <IsBreakWhenHit>1</IsBreakWhenHit>");
                stw.WriteLine("  <IsRunMacroWhenHit>0</IsRunMacroWhenHit>");
                stw.WriteLine("  <UseChecksum>1</UseChecksum>");
                stw.WriteLine("  <Labels />");
                stw.WriteLine("  <RequestRemapped>0</RequestRemapped>");
                stw.WriteLine("  <IsSnapshotWhenHit>1</IsSnapshotWhenHit>");
                stw.WriteLine("  <SnapshotCountTarget>1</SnapshotCountTarget>");
                stw.WriteLine("  <parentIndex>-1</parentIndex>");
                stw.WriteLine("</Breakpoint>");
            }
        }
    }
}
