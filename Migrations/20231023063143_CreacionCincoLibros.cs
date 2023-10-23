﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibrosAPI.Migrations
{
    /// <inheritdoc />
    public partial class CreacionCincoLibros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "IdProducto", "Autor", "Cantidad", "Costo", "Descripcion", "Genero", "Nombre" },
                values: new object[,]
                {
                    { 1, "Sarah J. Maas", 20, 17.75, "Cuando la cazadora de diecinueve años de edad, Feyre, mata a un lobo el el bosque, una criatura parecida a una bestia llega para exigir venganza. Arrastrada a una traicionera tierra mágica que solo conoce de leyendas, Feyre descubre que su captor no es un animal, sino Tamlin, una de las letales e inmortales hadas que una vez gobernaron su mundo.\nA medida que ella vive en su estado, sus sentimientos por Tamlin se transforman de una hostilidad helada a una pasión que quema a pesar de todas las mentiras y las advertencias que se le han hecho sobre el hermoso y peligroso mundo de las hadas. Pero una antigua y malvada sombre crece sobre las tierras feéricas, y Feyre debe encontrar la manera de detenerla... o condenará a Tamlin, y su mundo, para siempre. ", "Fantasia", "A Court of Thorns and Roses" },
                    { 2, "Sarah J. Maas", 20, 18.5, "Tras haber superado más pruebas de lo que un corazón humano puede soportar, Feyre regresa a la Corte Primavera con los poderes de una alta fae. Sin embargo, no consigue olvidar los crímenes que debió cometer para salvar a Tamlin y a su pueblo, ni el perverso pacto que cerró con Rhysand, el alto lord de la temible Corte Noche. \nMientras Feyre es arrastrada hacia el interior de la oscura red política y pasional de Rhysand, una guerra inminente acecha y un mal mucho más peligroso que cualquier reina amenaza con destruir todo lo que Feyre alguna vez intentó proteger. Ella podría ser la clave para detenerlo, pero solo si consigue dominar sus nuevos dones, sanar su alma partida en dos y decidir su futuro y el de todo un mundo en crisis. \nLa autora número uno en ventas en The New York Times y USA Today, Sarah J. Maas, lleva esta saga más que adictiva a un nivel impensado.", "Fantasia", "A Court of Mist and Fury" },
                    { 3, "Sarah J. Maas", 20, 24.5, "Feyre regresa a la Corte Primavera, decidida a reunir información sobre los planes de Tamlin y del rey invasor que amenaza con destruir Prythian. Para esto deberá someterse a un letal y peligroso juego de engaño, en el que un simple error podría condenar no solo a Feyre, sino también a todo el mundo a su alrededor.\nA medida que la guerra avanza sin tregua, Feyre deberá posicionarse como una alta fae y luchar por dominar sus dones mágicos; tendrá que determinar en cuáles de los deslumbrantes altos lores puede confiar y salir a buscar aliados en los lugares más inesperados.\nEn este apasionante tercer volumen de la serie de Una corte de rosas y espinas de la exitosísima autora Sarah J. Maas, la tierra se teñirá de rojo mientras majestuosos ejércitos luchan por apoderarse del único objeto que podría destruirlos a todos. ", "Fantasia", "A Court of Wind and Ruins" },
                    { 4, "Sarah J. Maas", 20, 13.5, "Feyre, Rhys y su círculo más íntimo se encuentran reconstruyendo la Corte de la Noche y su mundo. Pero el Solsticio de Invierno finalmente llega... y con toda su fuerza. Aún su atmosfera festiva no puede contrarrestar que las sombras del pasado acechen en el presente. Feyre se da cuenta que los que más quiere guardan heridas del pasado de las que no era consciente. Cicatrices que tendrán un gran impacto en el futuro de su Corte.", "Fantasia", "A Court of Frost and Starlight" },
                    { 5, "Sarah J. Maas", 20, 16.0, " Un poder insondable.\nDesde que fue forzada a meterse en el Caldero y se convirtió en alta fae en contra de su voluntad, Nesta Archeron lucha por encontrar su propio lugar dentro del extraño y letal mundo en el que habita. A su temperamento irascible se suma la dificultad para superar los horrores de la guerra con Hybern y todo lo que perdió en ella.\nMientras que Cassian, miembro de la Corte Noche de Rhysand y Feyre, es designado para entrenar a la incontrolable Nesta y entre ellos se enciende el más ardiente de los fuegos, las traidoras reinas humanas forjan una nueva y peligrosa alianza que amenaza la frágil paz establecida entre los reinos. Y la clave para detenerlas podría depender de que Cassian y Nesta logren superar sus inquietantes pasados.\nEn un mundo arrasado por la guerra, Nesta y Cassian deberán enfrentarse tanto a sus monstruos interiores como a los que acechan en el exterior, y buscarán la aceptación –y la curación– en brazos del otro. ", "Fantasia", "A Court of Silver Flames" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 5);
        }
    }
}
