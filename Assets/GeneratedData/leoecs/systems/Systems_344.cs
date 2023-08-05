using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System344 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component435> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component415>())
   {
    q+=1;
    var com = entity.Get<Component415>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component465>())
   {
    q+=1;
    var com = entity.Get<Component465>();
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
   if (entity.Has<Component3>())
   {
    q+=1;
    var com = entity.Get<Component3>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
