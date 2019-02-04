import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';

import { FetchProduct } from './components/FetchProducts';
import { FetchData } from './components/FetchData';

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
            <Route path='/fetch-product' component={FetchProduct} />
            <Route path='/fetch-data' component={FetchData} />
      </Layout>
    );
  }
}
