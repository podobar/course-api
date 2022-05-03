//using Commander.Models.DTO;

//namespace Commander.Models.Mappers
//{
//    public static class Mapper
//    {

//        public static CommandReadDTO Map(Course command)
//        {
//            if (command == null)
//                return null;
//            return new CommandReadDTO()
//            {
//                Id = command.Id,
//                HowTo = command.HowTo,
//                Line = command.Line,
//            };
//        }
        
//        public static IEnumerable<CommandReadDTO> Map(IEnumerable<Command> commands)
//        {
//            if(commands == null)
//                return Enumerable.Empty<CommandReadDTO>();
//            return commands.Select(c => Map(c));
//        }

//        public static Command Map(CommandCreateDTO cmdDTO)
//        {
//            return new Command()
//            {
//                HowTo = cmdDTO.HowTo,
//                Line = cmdDTO.Line,
//                Platform = cmdDTO.Platform
//            };
//        }

//        public static void MapTo(this CommandUpdateDTO cmdDTO, Command cmd)
//        {
//            cmd.HowTo = cmdDTO.HowTo;
//            cmd.Line = cmdDTO.Line;
//            cmd.Platform = cmdDTO.Platform;
//        }

//        public static void MapTo(this Command cmd, CommandUpdateDTO cmdDTO)
//        {
//            cmdDTO.HowTo = cmd.HowTo;
//            cmdDTO.Line = cmd.Line;
//            cmdDTO.Platform = cmd.Platform;
//        }
//    }
//}
