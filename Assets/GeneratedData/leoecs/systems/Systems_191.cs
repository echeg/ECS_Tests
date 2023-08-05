using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System191 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component425,Component239,Component285> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component451>())
   {
    entity.Del<Component451>();
   }
   else
   {
    entity.Replace(new Component451());
   }
  }
 }
}

}
