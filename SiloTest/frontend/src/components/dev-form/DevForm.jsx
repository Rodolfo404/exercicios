import './DevForm.css'
import React, { Component } from 'react';
import {Button, TextField, Slider, FormControlLabel, Switch} from '@material-ui/core';

// class component
class DevForm extends Component {
  id;
  full_name;
  skill;
  level;
  birthday;
  profissional_status;

    valuetext(value) {
        return `${value}°C`;
    }
    handleId(event) {
      this.id = event.target.value;
    }
    handleFullName(event) {
      this.full_name = event.target.value;
    }
    handleSkill(event) {
      this.skill = event.target.value;
    }
    handleLevel(event, value){
      this.level =  value;
    }
    handleBirthday(event) {
      this.birthday = event.target.value;
    }
    handleProfessiolStatus(event) {
      this.profissional_status = event.target.checked;
    }
    handleSubmit(event){
      event.stopPropagation();
      event.preventDefault();
      let dev = {
          "id": this.id,
          "fullname":this.full_name, 
          "skill":this.skill, 
          "level":this.level, 
          "birthday":this.birthday,
          "professional_status":this.profissional_status
        }
        this.props.create(dev);
    }

    render() { 
        return (
          
          <form onSubmit={this.handleSubmit.bind(this)}>
            <TextField
              fullWidth
              margin="normal"
              id="id"
              label="Id"
              type="number"
              onChange={this.handleId.bind(this)}
            />
            <TextField
              fullWidth
              margin="normal"
              id="full-name"
              label="Full Name"
              onChange={this.handleFullName.bind(this)}
            />
            <TextField 
              fullWidth 
              margin="normal" 
              id="skill" 
              label="Skill" 
              onChange={this.handleSkill.bind(this)} 
            />

            <Slider
              id="level"
              defaultValue={0}
              getAriaValueText={this.valuetext}
              aria-labelledby="discrete-slider"
              valueLabelDisplay="auto"
              step={25}
              marks
              min={0}
              max={100}
              onChange={this.handleLevel.bind(this)}
            />
            <TextField
              fullWidth
              margin="normal"
              id="birthday"
              label="Birthday"
              type='date'
              InputLabelProps={{
                shrink: true,
              }}
              onChange={this.handleBirthday.bind(this)}
            />
            <FormControlLabel
            
              control={
                <Switch
                  onChange={this.handleProfessiolStatus.bind(this)}
                  id="professional-status"
                  name="professional-status"
                  color="primary"
                />
              }
              label="Professional Status"
            />
            <Button type="submit" variant="contained" color="primary">
              Save
            </Button>
          </form>
        );
    }
}
 
export default DevForm;