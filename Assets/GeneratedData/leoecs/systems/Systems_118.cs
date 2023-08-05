using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System118 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component243,Component14,Component370,Component284> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component491>())
   {
    entity.Del<Component491>();
   }
   else
   {
    entity.Replace(new Component491());
   }
  }
 }
}

}
