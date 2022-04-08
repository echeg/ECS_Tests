using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System49 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component168>().Inc<Component251>().Inc<Component405>().Inc<Component433>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component111>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component111>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component50>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component50>().Get(entity);
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
   if (_world.GetPool<Component153>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component153>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
