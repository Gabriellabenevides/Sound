Banda TheWeeknd = new Banda("The Weeknd");

Album albumDoTheWeeknd = new Album("After Hours");

Musica musica1 = new Musica(TheWeeknd, "Save your tears")
{
    Duracao = 215,
    Disponivel = true,
};

Musica musica2 = new Musica(TheWeeknd, "In your eyes")
{
    Duracao = 237,
    Disponivel = false,
};

albumDoTheWeeknd.AdicionarMusica(musica1);
albumDoTheWeeknd.AdicionarMusica(musica2);
TheWeeknd.AdicionarAlbum(albumDoTheWeeknd);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoTheWeeknd.ExibirMusicasDoAlbum();
TheWeeknd.ExibirDiscografia();