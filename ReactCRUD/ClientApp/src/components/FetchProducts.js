import * as React from 'react';

export class FetchProduct extends React.Component {
    displayName = FetchProduct.ProductName
    constructor(props) {
        super(props);
        this.state = { products: [], loading: true };
        fetch('api/Product/GetProducts')
            .then(response => response.json())
            .then(data => {
                this.setState({ products: data, loading: false });
            });
    }

    static renderProductTable(products) {
        return (
            <table className='table table-striped'>
                <thead>
                    <tr>
                        <th>Products Table</th>
                    </tr>
                </thead>
                <tbody>
                    {products.map(product =>
                        <tr key={product.productID}>
                            <td>{product.productName}</td>
                            <td>{product.price}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    };

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : FetchProduct.renderProductTable(this.state.products);

        return (
            <div>
                <h1>Products</h1>
                <p>This component demonstrates fetching data from the server.</p>
                {contents}
            </div>
        );
    }
};