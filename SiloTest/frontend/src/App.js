import { Component, Fragment } from 'react';
import './assets/css/App.css';
import DevForm from './components/dev-form';
import DevList from './components/dev-list';
import { Container, Divider} from '@material-ui/core';

class App extends Component {
  devs = [];

  constructor(){
    super();
    this.state = {
      devs : this.devs
    }
  }
  create_dev(dev){
    console.log(dev);
    let lista = [...this.devs, dev];
    this.setState({
      devs : lista
    });
  }
  render(){
    return (
      <Fragment>
        <Container maxWidth='sm' >
          <h1>Dev Register</h1>
          <DevForm create={this.create_dev.bind(this)}/>
        </Container>
        <Divider variant="middle" />
        <Container>
          <DevList devs={this.state.devs}/>
        </Container>    
      </Fragment>
    )
  }
}

export default App;
