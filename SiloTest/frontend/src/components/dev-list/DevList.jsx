import React, { Component } from "react";
import { DataGrid } from "@material-ui/data-grid";

class DevList extends Component {

  get_devs(){
    return this.props.devs
  }
  columns = [
    {
      field: "id",
      headerName: "Id",
      width: 150,
      editable: true,
    },
    {
      field: "fullname",
      headerName: "Full Name",
      width: 150,
      editable: true,
    },
    {
      field: "skill",
      headerName: "Skills",
      width: 150,
      editable: true,
    },
    {
      field: "level",
      headerName: "Level",
      type: "number",
      width: 150,
      editable: true,
    },
    {
      field: "birthday",
      headerName: "Birthday",
      sortable: true,
      width: 160,
    },
    {
      field: "professional_status",
      headerName: "Status",
      sortable: true,
      width: 160,
    }
  ];
  render() {
    return (
      <div style={{ height: 250 }}>
        <DataGrid
          rows={this.get_devs()}
          columns={this.columns}
          pageSize={5}
          rowsPerPageOptions={[5]}
          checkboxSelection
          disableSelectionOnClick          
        />
      </div>
    );
  }
}

export default DevList;
