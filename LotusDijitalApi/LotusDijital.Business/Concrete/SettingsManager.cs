using AutoMapper;
using LotusDijital.Business.Abstract;
using LotusDijital.Data.Abstract;
using LotusDijital.Entity;
using LotusDijital.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Business.Concrete
{
    public class SettingsManager : ISettingsService
    {
        private readonly ISettingsRepository _settingsRepository;
        private readonly IMapper _mapper;

        public SettingsManager(ISettingsRepository settingsRepository, IMapper mapper)
        {
            _settingsRepository = settingsRepository;
            _mapper = mapper;
        }

        public Task<bool> DeleteAsync(SettingsDto tDto)
        {
            throw new NotImplementedException();
        }

        public Task<List<SettingsDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<SettingsDto> GetByIdAsync(int id)
        {
            var setting = await _settingsRepository.GetByIdAsync(id);
            var settingDto = _mapper.Map<SettingsDto>(setting);
            return settingDto;
        }

        public Task<List<SettingsDto>> GetManyAsync(Expression<Func<SettingsDto, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(SettingsDto settingsDto)
        {
            var setting = _mapper.Map<Settings>(settingsDto);
            var result = await _settingsRepository.UpdateAsync(setting);
            return result != null;
        }
    }
}
