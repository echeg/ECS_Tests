using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System359 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component420,Component451,Component236> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component426>())
   {
    entity.Del<Component426>();
   }
   else
   {
    entity.Replace(new Component426());
   }
  }
 }
}

}
