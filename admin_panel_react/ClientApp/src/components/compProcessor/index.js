import React, { Component } from 'react';

export default class Index extends Component {

    constructor(props) {
        super(props);
        this.state = { items: [], loading: true };
        this.setTypePage = props.setTypePage;
    }

    componentDidMount() {
        this.getItem();
    }

    renderCompBodiesTable(items) {
        return (
            <table className="table">
                <thead>
                    <tr>
                        <th>
                        Name
                        </th>
                        <th>
                            Producer
                        </th>
                        <th>
                            Socket
                        </th>
                        <th>
                            CountCores
                        </th>
                        <th>
                            CountThreads
                        </th>
                        <th>
                            Frequency
                        </th>
                        <th>
                            TurboTechnology
                        </th>
                        <th>
                            TypeRam
                        </th>
                        <th>
                            HaveVideoCard
                        </th>
                        <th>
                            Price
                        </th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>

                    {items.map(item =>
                        <tr key={item.id}>
                            <td>{item.name}</td>
                            <td>
                                {item.producer}
                            </td>
                            <td>
                                {item.socket}
                            </td>
                            <td>
                                {item.countCores}
                            </td>
                            <td>
                                {item.countThreads}
                            </td>
                            <td>
                                {item.frequency}
                            </td>
                            <td>
                                {item.turboTechnology}
                            </td>
                            <td>
                                {item.typeRam}
                            </td>
                            <td>
                                {item.haveVideoCard+""}
                            </td>
                            <td>
                                {item.price}
                            </td>
                            <td>
                                <a onClick={(ev) => {
                                    this.setTypePage("Edit", item.id);
                                }}>Edit</a> |
                                <a onClick={(ev) => {
                                    this.setTypePage("Detail", item.id);
                                }}>Detail</a> |
                                <a onClick={(ev) => {
                                    this.deleteItem(item.id);
                                }}>Delete</a>
                            </td>
                        </tr>
                    )}
                </tbody>

            </table>
           
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : this.renderCompBodiesTable(this.state.items);

        return (
            <div>
                <p>
                    <a onClick={(ev) => {

                        this.setTypePage("Create");
                    }
                    }>Add computer body</a>
                </p>
                {contents}
            </div>
        );
    }

    async getItem() {
        const response = await fetch('compprocessors');
        const data = await response.json();
        this.setState({ items: data, loading: false });
    }

    async deleteItem(Id) {
        const response = await fetch('compprocessors/delete?id=' + Id);
        //������ ��������� ������

        const response2 = await fetch('compprocessors');
        const data = await response2.json();
        this.setState({ items: data, loading: false });

    }
}