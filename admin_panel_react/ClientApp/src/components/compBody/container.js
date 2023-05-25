import React, { Component } from 'react';
import Index from './index'
import Create from './create'
import Detail from './detail'
import Edit from './edit'

export class CompBodyContainer extends Component {
    static displayName = CompBodyContainer.name;

    constructor(props) {
        super(props);
        this.state = {
            items: [],
            loading: true,
            page: "Index",
            itemId:null
        };
        this.setTypePage = this.setTypePage.bind(this);
    }

    setTypePage(Page, keepItemId) {
        this.setState({
            page: Page,
            itemId: keepItemId
        });
    }

    render() {

        return (
            <div>
                <h1 id="tableLabel">Comp Bodies</h1>


                {this.state.page == "Index" ?
                    <Index setTypePage={this.setTypePage} />
                    : null}
                {this.state.page == "Create" ?
                    <Create setTypePage={this.setTypePage} />
                    : null}
                {this.state.page == "Detail" ?
                    <Detail setTypePage={this.setTypePage} itemId={this.state.itemId} />
                    : null}
                {this.state.page == "Edit" ?
                    <Edit setTypePage={this.setTypePage} itemId={this.state.itemId} />
                    : null}
            </div>
        );
    }
}


//<Create loginUser={this.state.loginUser} setTypeRepos={this.setTypeRepos} changeUserName={this.setTypeUser} />
//                    : null}