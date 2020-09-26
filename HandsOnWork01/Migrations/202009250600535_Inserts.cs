namespace HandsOnWork01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inserts : DbMigration
    {
        public override void Up()
        {
            Sql("insert into bulas (Nome,Apresentacao,Uso,Composicao,Indicacao) values ('Advil (ibuprofeno)','Cápsulas gelatinosas moles','Uso Adulto','Ibuprofeno 400mg',' Indicado no alívio temporário da febre e de dores de leve a moderada intensidade, como cefaléia tensional, lombalgia, dor muscular, enxaqueca, dismenorréia, de gripes e resfriados comuns, de artrite e dor-de-dente.')");
            Sql("insert into bulas (Nome,Apresentacao,Uso,Composicao,Indicacao) values ('Amoxicilina','Embalagem com 14 ou 20 comprimidos revestidos contendo 875 mg de amoxicilina tri-hidratada','Uso Adulto e Pediátrico','875 mg de amoxicilina tri-hidratada','Indicado para tratamento de infecções bacterianas causadas por germes sensíveis à ação da amoxicilina.')");
            Sql("insert into bulas (Nome,Apresentacao,Uso,Composicao,Indicacao) values ('Aspirina c','Comprimidos efervescentes. Envelopes contendo 2 comprimidos efervescentes e embalagens contendo 10 comprimidos efervescentes.','Uso Adulto e Pediátrico','400 mg de ácido acetilsalicílico e 240 mg de ácido ascórbico',' Alívio sintomático da dor de cabeça, dor de dente, dor causada por inflamação da garganta, dor muscular, dor articular, dor nas costas (lombalgia); Alívio sintomático da dor e da febre causadas por gripes e resfriados')");
            Sql("insert into bulas (Nome,Apresentacao,Uso,Composicao,Indicacao) values ('Benzetacil','Embalagem contendo 1 ou 10 frascos-ampola com 4 mL.','Uso Adulto e Pediátrico','Benzilpenicilina benzatina 150.000 U; Excipientes: citrato de sódio, povidona, edetato dissódico, propilparabeno, metilparabeno, metabissulfito de sódio, lecitina de soja, polissorbato 80, água para injeção.','Indicado no tratamento de infecções causadas por germes sensíveis à penicilina G; Infecções leves e moderadas do trato respiratório superior e da pele; Profilaxia da glomerulonefrite aguda e doença reumática; Profilaxia de recorrências da febre reumática e/ou coréia; Infecções venéreas.')");
            Sql("insert into bulas (Nome,Apresentacao,Uso,Composicao,Indicacao) values ('Bromoprida','Solução Oral – 1mg/Ml','Uso Adulto e Pediátrico','Bromoprida 4mg e excipientes 1 mL','Indicado para distúrbios da motilidade gastrintestinal; Refluxo gastroesofágico; Náuseas e vômitos de origem central e periférica (cirurgias, metabólicas, infecciosas e problemas secundários ao uso de medicamentos).')");
            Sql("insert into bulas (Nome,Apresentacao,Uso,Composicao,Indicacao) values ('Captopril','Comprimido de 12,5 mg em embalagem com 15, 30, 150, 160, 200, 280, 400 ou 600 comprimidos.','Uso Adulto','captopril 12,5 mg e excipientes','Indicado para o tratamento da hipertensão; Indicado no tratamento da insuficiência cardíaca congestiva em associação com diuréticos e digitálicos; Indicado para o tratamento de nefropatia diabética; Indicado como terapia pós-infarto do miocárdio em pacientes clinicamente estáveis com disfunção ventricular')");
            Sql("insert into bulas (Nome,Apresentacao,Uso,Composicao,Indicacao) values ('Cefalexina','Cefalexina suspensão oral 250 mg / 5 ml; Embalagens com frasco de vidro contendo 60ml ou 100 ml de suspensão oral preparada + 1 copo de medida.','Uso Adulto e Pediátrico','Cefalexina monoidratada equivalente a 500 mg de cefalexina base.','Indicado para o tratamento de infecções: Sinusites bacterianas; Infecções do trato respiratório; Infecções da pele e tecidos moles; Infecções ósseas.')");
            Sql("insert into bulas (Nome,Apresentacao,Uso,Composicao,Indicacao) values ('Dipirona','Solução Gotas 500 mg/mL: Frascos com 10 mL ou 20 mL','Uso Adulto e Pediátrico','Dipirona monoidratada 500 mg e excipientes',' Indicado como antitérmico (para febre) e analgésico (para dor).')");
            Sql("insert into bulas (Nome,Apresentacao,Uso,Composicao,Indicacao) values ('Glifage','Glifage® 500 mg / Glifage® 850 mg / Glifage® 1 g; Embalagens contendo 30 comprimidos revestidos.','Uso Adulto e Pediátrico','Cloridrato de metformina 500 mg','Indicado como agente antidiabético, associado ao regime alimentar, para Diabetes tipo 2 e tipo 1.')");
        }
        
        public override void Down()
        {
        }
    }
}
