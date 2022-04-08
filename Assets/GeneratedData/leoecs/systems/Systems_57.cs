using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System57 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component455,Component243,Component14,Component370> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component284>())
   {
    q+=1;
    var com = entity.Get<Component284>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component491>())
   {
    q+=1;
    var com = entity.Get<Component491>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component177>())
   {
    q+=1;
    var com = entity.Get<Component177>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component142>())
   {
    q+=1;
    var com = entity.Get<Component142>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
