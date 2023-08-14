using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System394 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component4,Component442,Component437> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component190>())
   {
    entity.Del<Component190>();
   }
   else
   {
    entity.Replace(new Component190());
   }
  }
 }
}

}
