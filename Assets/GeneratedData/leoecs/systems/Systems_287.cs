using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System287 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component259,Component96> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component483>())
   {
    q+=1;
    var com = entity.Get<Component483>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component37>())
   {
    q+=1;
    var com = entity.Get<Component37>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component190>())
   {
    q+=1;
    var com = entity.Get<Component190>();
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
  }
 }
}

}
