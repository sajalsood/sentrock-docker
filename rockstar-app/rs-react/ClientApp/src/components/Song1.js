import React, { useState, useEffect } from 'react';

export default function Song1() {

  const [song, setSong] = useState({});
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    document.addEventListener("selectionchange", event => { });

    (async () => {
      const response = await fetch('song/' + 1);
      const data = await response.json();
      setSong(data);
      setLoading(false);
    })();
  }, []);

  function renderSong(song) {
    return (
        <div className="m-10">
          <div className="card m-2">
            <img className="card-img-top card-img-pos" src={`${process.env.PUBLIC_URL}/images/${song.imageUrl}`} alt="Card image"  />
          </div>
          <div className="text-center pt-5">
            <div>  
              <button className="btn btn-warning" onClick={getPolarity} value="Polarity">Polarity</button>  
              <div className="text-danger m-3">{song.polarity}</div>
            </div>
            <h1 className="text-info text-center">{song.name}</h1>
            <p className="text-success m-3" dangerouslySetInnerHTML={{__html: song.lyrics}} />
            <h5 className="text-primary text-center">- {song.artist}</h5>
          </div>
        </div>
    );
  }

  function renderLoadingMessage() {
    return (<p><em>Loading...</em></p>);
  }

  function getPolarity() {
    console.log("here");
    let selection = document.getSelection ? document.getSelection().toString() :  document.selection.createRange().toString() ;

    const polarity = async () => {
      const response = await fetch('song/polarity?lyric=' + selection);
      const data = await response.json();
      setSong({...song, polarity: data.polarity } );
    };

    if(selection != "") {
      polarity();
    }
  };

  return (
    <div>
      {loading ? renderLoadingMessage() : renderSong(song)}
    </div>
  );
}
