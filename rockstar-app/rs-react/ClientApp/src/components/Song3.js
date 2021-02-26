import React, { Component } from 'react';

export class Song3 extends Component {
  static displayName = Song3.name;

  constructor(props) {
    super(props);
    this.state = { song: [], loading: true };
  }

  componentDidMount() {
    this.populateSongData();
  }

  static renderSong(song) {
    return (
      <div className="m-10">
          <div className="card m-2">
            <img className="card-img-top card-img-pos" src={`${process.env.PUBLIC_URL}/images/${song.imageUrl}`} alt="Card image"  />
          </div>
          <div className="text-center pt-5">
            <h1 className="text-info text-center">{song.name}</h1>
            <p className="text-success m-3" dangerouslySetInnerHTML={{__html: song.lyrics}} />
            <h5 className="text-primary text-center">- {song.artist}</h5>
          </div>
        </div>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : Song3.renderSong(this.state.song);

    return (
      <div>
        {contents}
      </div>
    );
  }

  async populateSongData() {
    const response = await fetch('song/' + 3);
    const data = await response.json();
    this.setState({ song: data, loading: false });
  }
}
