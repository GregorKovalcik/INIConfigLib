# INIConfigLib
INI configuration file .NET library.


### Functionality split:
* [ ] **INIConfiguration** <br/>
  Structure holding configuration data, allowing option value changes.
* [ ] **INIConfigBuilder** <br/>
  Building a custom INIConfiguration.
* [ ] **INIReader/INIWriter** <br/>
  Reading/writing an INIConfiguration from an input file/string/stream, conforming to a provided INIConfiguration.


### Requirements are satisfied by:
* **INIConfigBuilder -> INIConfiguration** <br/>
  To specify concrete format of a configuration file.
* **INIReader(INIConfiguration, inputFile, INIReaderModeEnum strict/relaxed) -> INIConfiguration** <br/>
  Load a configuration file and verify whether it comply with the given format in one of the two modes.
* **INIConfiguration.Properties** <br/>
  Allow convenient access to loaded configuration including changing values for the options.
* **INIWriter(INIConfiguration config, INIWriterModeEnum minimal/all)** <br/>
  Write the configuration back to the file so that the new file is similar to the old one after the changes are made, e.g. the new file should not contain options with default values if these options were not defined in the original file.
  Write a default configuration of all sections and options including documentation comments.
* **INIReader(INIConfiguration, Stream, INIReaderModeEnum strict/relaxed)** <br/>
  Allow writing and reading of a configuration to/from a buffer in memory (string, stream, ...) for testing purposes.

  
### INIConfiguration
* Graph representation of the configuration: <br/>
  Configuration -> Sections -> Options -> [Identifier = Element] -> ElementType, ElementReference...
* List of sections + their parameters (is optional,...).
* For each section: list of available options.
* Option parameters:
  * identificator, 
  * isOptional, 
  * 1/more elements (scalar/array), 
  * type, 
  * default value for optionals, 
  * option description + allowed values
  
### INIReader/INIWriter : INIIO
* Array value separator as parameter (,:)


### INIWriterModeEnum
* **Minimal** <br/>
  Write only necessary options, file should be similar (e.g. no default values that were not in original file).
* **All** <br/>
  Including optional options with default values and comments.

  
### INIReaderModeEnum
* **Strict** <br/>
  Unknown sections/options are not allowed.
* **Relaxed** <br/>
  Unknown sections/options are stored as string.
  
