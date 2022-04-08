using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System85 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component202>().Inc<Component60>().Inc<Component360>().Inc<Component143>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component137>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component137>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component343>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component343>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component106>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component106>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component7>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component7>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
